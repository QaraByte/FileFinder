namespace FileFinder;

public partial class MainForm : Form
{
    private CancellationTokenSource? _cts;
    private bool _isSearching;
    private readonly List<string> _allResults = new();

    public MainForm()
    {
        InitializeComponent();
        menuOpen.Image       = IconHelper.GetFileIcon();
        menuOpenFolder.Image = IconHelper.GetFolderIcon();
        menuProperties.Image = IconHelper.GetPropertiesIcon();
        picTxt.Image   = IconHelper.GetExtensionIcon(".txt");
        picWord.Image  = IconHelper.GetExtensionIcon(".docx");
        picExcel.Image = IconHelper.GetExtensionIcon(".xlsx");
        picPdf.Image   = IconHelper.GetExtensionIcon(".pdf");
        picMp3.Image   = IconHelper.GetExtensionIcon(".mp3");
        picPpt.Image   = IconHelper.GetExtensionIcon(".pptx");
        picImg.Image   = IconHelper.GetExtensionIcon(".jpg");
        LicenseService.Initialize();
        ApplyLicenseState();
        ApplyLanguage();
        PopulateDrives();
    }

    private void ApplyLanguage()
    {
        lblFound.Text         = Lang.Found;
        lblDrive.Text         = Lang.DriveLabel;
        lblSearch.Text        = Lang.FilterLabel;
        grpFileTypes.Text     = Lang.FileTypesGroup;
        chkTxt.Text           = Lang.ChkTxt;
        chkWord.Text          = Lang.ChkWord;
        chkExcel.Text         = Lang.ChkExcel;
        chkPdf.Text           = Lang.ChkPdf;
        chkMp3.Text           = Lang.ChkMp3;
        chkPpt.Text           = Lang.ChkPpt;
        chkImg.Text           = Lang.ChkImg;
        lblLicenseNotice.Text = Lang.ProNotice;
        btnSearch.Text        = Lang.BtnSearch;
        btnSave.Text          = Lang.BtnSave;
        menuOpen.Text         = Lang.MenuOpen;
        menuOpenFolder.Text   = Lang.MenuOpenFolder;
        menuProperties.Text   = Lang.MenuProperties;
        btnLang.Text          = Lang.Current == "ru" ? "EN" : "RU";
    }

    private void ApplyLicenseState()
    {
        bool licensed = LicenseService.Current?.IsActive == true;
        chkPdf.Enabled = licensed;
        chkMp3.Enabled = licensed;
        chkPpt.Enabled = licensed;
        chkImg.Enabled = licensed;
        lblLicenseNotice.Visible = !licensed;
        if (!licensed)
        {
            chkPdf.Checked = false;
            chkMp3.Checked = false;
            chkPpt.Checked = false;
            chkImg.Checked = false;
        }
    }

    private void PopulateDrives()
    {
        var selected = cmbDrive.SelectedItem?.ToString();
        cmbDrive.Items.Clear();
        foreach (var drive in DriveInfo.GetDrives())
        {
            if (drive.IsReady)
                cmbDrive.Items.Add(drive.Name.TrimEnd('\\'));
        }
        if (selected != null && cmbDrive.Items.Contains(selected))
            cmbDrive.SelectedItem = selected;
        else if (cmbDrive.Items.Count > 0)
            cmbDrive.SelectedIndex = 0;
    }

    private void btnRefreshDrives_Click(object sender, EventArgs e)
    {
        PopulateDrives();
    }

    private async void btnSearch_Click(object sender, EventArgs e)
    {
        if (_isSearching)
        {
            _cts?.Cancel();
            return;
        }

        var extensions = GetSelectedExtensions();
        if (extensions.Count == 0)
        {
            MessageBox.Show(Lang.MsgSelectType, "FileFinder",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbDrive.SelectedItem == null) return;

        string root = cmbDrive.SelectedItem.ToString()! + "\\";

        _allResults.Clear();
        listResults.Items.Clear();
        lblFound.Text = Lang.FoundN(0);
        statusLabel.Text = Lang.StatusSearching;
        btnSave.Enabled = false;
        _cts = new CancellationTokenSource();
        _isSearching = true;
        btnSearch.Text = Lang.BtnStop;

        try
        {
            await Task.Run(() => SearchFiles(root, extensions, _cts.Token));
        }
        catch (OperationCanceledException) { }
        finally
        {
            _isSearching = false;
            btnSearch.Text = Lang.BtnSearch;
            bool licensed = LicenseService.Current?.IsActive == true;
            btnSave.Enabled = licensed && listResults.Items.Count > 0;
            lblFound.Text = Lang.FoundN(listResults.Items.Count);
            statusLabel.Text = _cts.IsCancellationRequested
                ? Lang.StatusStopped
                : Lang.StatusDone(listResults.Items.Count);
        }
    }

    private void SearchFiles(string root, List<string> extensions, CancellationToken ct)
    {
        var stack = new Stack<string>();
        stack.Push(root);

        while (stack.Count > 0 && !ct.IsCancellationRequested)
        {
            string dir = stack.Pop();
            BeginInvoke(() => statusLabel.Text = dir);
            try
            {
                foreach (string file in Directory.EnumerateFiles(dir))
                {
                    if (ct.IsCancellationRequested) return;

                    string ext = Path.GetExtension(file).ToLowerInvariant();
                    if (!extensions.Contains(ext)) continue;

                    Invoke(() =>
                    {
                        _allResults.Add(file);
                        if (MatchesFilter(file))
                        {
                            listResults.Items.Add(file);
                            lblFound.Text = Lang.FoundN(listResults.Items.Count);
                        }
                    });
                }
            }
            catch (UnauthorizedAccessException) { }
            catch (IOException) { }

            try
            {
                foreach (string subDir in Directory.GetDirectories(dir))
                    stack.Push(subDir);
            }
            catch (UnauthorizedAccessException) { }
            catch (IOException) { }
        }
    }

    private bool MatchesFilter(string path)
    {
        string filter = txtSearch.Text.Trim();
        return filter.Length == 0 || path.Contains(filter, StringComparison.OrdinalIgnoreCase);
    }

    private void ApplyFilter()
    {
        listResults.BeginUpdate();
        listResults.Items.Clear();
        foreach (string path in _allResults)
        {
            if (MatchesFilter(path))
                listResults.Items.Add(path);
        }
        listResults.EndUpdate();
        lblFound.Text = Lang.FoundN(listResults.Items.Count);
    }

    private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();

    private List<string> GetSelectedExtensions()
    {
        var list = new List<string>();
        if (chkTxt.Checked) list.Add(".txt");
        if (chkWord.Checked) { list.Add(".doc"); list.Add(".docx"); }
        if (chkExcel.Checked) { list.Add(".xls"); list.Add(".xlsx"); }
        if (chkPdf.Checked) list.Add(".pdf");
        if (chkMp3.Checked) list.Add(".mp3");
        if (chkPpt.Checked) { list.Add(".ppt"); list.Add(".pptx"); }
        if (chkImg.Checked) { list.Add(".jpg"); list.Add(".jpeg"); list.Add(".png"); list.Add(".gif"); list.Add(".bmp"); }
        return list;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (listResults.Items.Count == 0) return;

        using var dlg = new SaveFileDialog
        {
            Filter = "Text file (*.txt)|*.txt",
            FileName = "results.txt",
            DefaultExt = "txt"
        };

        if (dlg.ShowDialog() != DialogResult.OK) return;

        File.WriteAllLines(dlg.FileName, listResults.Items.Cast<string>());
        MessageBox.Show(Lang.SavedMsg(dlg.FileName), "FileFinder",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
    }

    private void btnLang_Click(object sender, EventArgs e)
    {
        Lang.Switch();
        btnLang.Text = Lang.Current == "ru" ? "EN" : "RU";
        statusLabel.Text = Lang.RestartToApply;
    }

    private void listResults_DoubleClick(object sender, EventArgs e)
    {
        if (listResults.SelectedItem is string path)
            FileService.OpenFile(path);
    }

    private void menuOpen_Click(object sender, EventArgs e)
    {
        if (listResults.SelectedItem is string path)
            FileService.OpenFile(path);
    }

    private void menuOpenFolder_Click(object sender, EventArgs e)
    {
        if (listResults.SelectedItem is string path)
            FileService.OpenFolder(path);
    }

    private void menuProperties_Click(object sender, EventArgs e)
    {
        if (listResults.SelectedItem is not string path) return;
        var props = FilePropertiesService.GetProperties(path);
        using var dlg = new FilePropertiesDialog(props);
        dlg.ShowDialog(this);
    }

    private void btnHelp_Click(object sender, EventArgs e)
    {
        using var dlg = new AboutDialog();
        dlg.ShowDialog(this);
        ApplyLicenseState();
    }

    private void lblSearch_Click(object sender, EventArgs e) { }
}
