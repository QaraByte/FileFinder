using System.Runtime.InteropServices;

namespace FileFinder;

static class IconHelper
{
    [DllImport("shell32.dll", CharSet = CharSet.Auto)]
    private static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes,
        ref SHFILEINFO psfi, uint cbSizeFileInfo, uint uFlags);

    [DllImport("user32.dll")]
    private static extern bool DestroyIcon(IntPtr hIcon);

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
    private struct SHFILEINFO
    {
        public IntPtr hIcon;
        public int iIcon;
        public uint dwAttributes;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)] public string szDisplayName;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]  public string szTypeName;
    }

    private const uint SHGFI_ICON             = 0x100;
    private const uint SHGFI_SMALLICON        = 0x001;
    private const uint SHGFI_USEFILEATTRIBUTES = 0x010;
    private const uint FILE_ATTRIBUTE_NORMAL   = 0x80;
    private const uint FILE_ATTRIBUTE_DIRECTORY = 0x10;

    public static Image GetFileIcon()
        => ShellIcon("file.txt", FILE_ATTRIBUTE_NORMAL, small: true);

    public static Image GetFolderIcon()
        => ShellIcon("folder", FILE_ATTRIBUTE_DIRECTORY, small: true);

    public static Image GetPropertiesIcon()
        => new Bitmap(SystemIcons.Information.ToBitmap(), 16, 16);

    public static Image GetExtensionIcon(string extension)
        => ShellIcon("file" + extension, FILE_ATTRIBUTE_NORMAL, small: false);

    private static Image ShellIcon(string fakePath, uint fileAttributes, bool small)
    {
        uint flags = SHGFI_ICON | SHGFI_USEFILEATTRIBUTES | (small ? SHGFI_SMALLICON : 0u);
        int size = small ? 16 : 32;

        var info = new SHFILEINFO();
        SHGetFileInfo(fakePath, fileAttributes, ref info, (uint)Marshal.SizeOf(info), flags);

        if (info.hIcon == IntPtr.Zero)
            return new Bitmap(size, size);

        using var icon = Icon.FromHandle(info.hIcon);
        var bmp = new Bitmap(icon.ToBitmap(), size, size);
        DestroyIcon(info.hIcon);
        return bmp;
    }
}
