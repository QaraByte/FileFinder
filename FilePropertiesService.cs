using System.IO.Compression;
using System.Xml;

namespace FileFinder;

static class FilePropertiesService
{
    public static FileProperties GetProperties(string path)
    {
        var info = new FileInfo(path);
        return new FileProperties(
            Name: info.Name,
            Path: path,
            Size: FormatSize(info.Length),
            Author: TryGetAuthor(path),
            CreatedAt: info.CreationTime.ToString("dd.MM.yyyy HH:mm:ss")
        );
    }

    private static string FormatSize(long bytes)
    {
        if (bytes >= 1024 * 1024)
            return $"{bytes / (1024.0 * 1024.0):F2} МБ";
        return $"{Math.Max(bytes / 1024.0, 0.1):F1} КБ";
    }

    private static string TryGetAuthor(string path)
    {
        string ext = Path.GetExtension(path).ToLowerInvariant();

        if (ext is ".docx" or ".xlsx")
            return ReadOpenXmlAuthor(path);

        // для остальных форматов пробуем Shell32 через позднее связывание
        return TryGetShellAuthor(path);
    }

    private static string ReadOpenXmlAuthor(string path)
    {
        try
        {
            using var zip = ZipFile.OpenRead(path);
            var entry = zip.GetEntry("docProps/core.xml");
            if (entry == null) return "-";

            using var stream = entry.Open();
            var doc = new XmlDocument();
            doc.Load(stream);

            var ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("dc", "http://purl.org/dc/elements/1.1/");
            var node = doc.SelectSingleNode("//dc:creator", ns);
            string? author = node?.InnerText.Trim();
            return string.IsNullOrEmpty(author) ? "-" : author;
        }
        catch
        {
            return "-";
        }
    }

    private static string TryGetShellAuthor(string path)
    {
        try
        {
            var shellType = Type.GetTypeFromProgID("Shell.Application");
            if (shellType == null) return "-";

            dynamic shell = Activator.CreateInstance(shellType)!;
            dynamic folder = shell.NameSpace(Path.GetDirectoryName(path));
            dynamic file = folder.ParseName(Path.GetFileName(path));

            // индекс 20 — "Авторы" в Windows 10/11
            string author = folder.GetDetailsOf(file, 20)?.Trim() ?? "";
            return string.IsNullOrEmpty(author) ? "-" : author;
        }
        catch
        {
            return "-";
        }
    }
}

public record FileProperties(string Name, string Path, string Size, string Author, string CreatedAt);
