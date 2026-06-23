namespace FileFinder;

public partial class MainForm : Form
{
    private CancellationTokenSource? _cts;
    private bool _isSearching;

    public MainForm()
    {
        InitializeComponent();
        PopulateDrives();
    }

    private void PopulateDrives()
    {
        cmbDrive.Items.Clear();
        foreach (var drive in DriveInfo.GetDrives())
        {
            if (drive.IsReady)
                cmbDrive.Items.Add(drive.Name.TrimEnd('\\'));
        }
        if (cmbDrive.Items.Count > 0)
            cmbDrive.SelectedIndex = 0;
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
            MessageBox.Show("Выберите хотя бы один тип файлов.", "FileFinder",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        if (cmbDrive.SelectedItem == null) return;

        string root = cmbDrive.SelectedItem.ToString()! + "\\";
        string nameFilter = txtSearch.Text.Trim().ToLowerInvariant();

        listResults.Items.Clear();
        lblFound.Text = "Найдено: 0";
        btnSave.Enabled = false;
        _cts = new CancellationTokenSource();
        _isSearching = true;
        btnSearch.Text = "Стоп";

        try
        {
            await Task.Run(() => SearchFiles(root, extensions, nameFilter, _cts.Token));
        }
        catch (OperationCanceledException) { }
        finally
        {
            _isSearching = false;
            btnSearch.Text = "Поиск";
            btnSave.Enabled = listResults.Items.Count > 0;
            lblFound.Text = $"Найдено: {listResults.Items.Count}";
        }
    }

    private void SearchFiles(string root, List<string> extensions, string nameFilter, CancellationToken ct)
    {
        var stack = new Stack<string>();
        stack.Push(root);

        while (stack.Count > 0 && !ct.IsCancellationRequested)
        {
            string dir = stack.Pop();
            try
            {
                foreach (string file in Directory.EnumerateFiles(dir))
                {
                    if (ct.IsCancellationRequested) return;

                    string ext = Path.GetExtension(file).ToLowerInvariant();
                    if (!extensions.Contains(ext)) continue;

                    string name = Path.GetFileName(file).ToLowerInvariant();
                    if (nameFilter.Length > 0 && !name.Contains(nameFilter)) continue;

                    Invoke(() =>
                    {
                        listResults.Items.Add(file);
                        lblFound.Text = $"Найдено: {listResults.Items.Count}";
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

    private List<string> GetSelectedExtensions()
    {
        var list = new List<string>();
        if (chkTxt.Checked) list.Add(".txt");
        if (chkWord.Checked) { list.Add(".doc"); list.Add(".docx"); }
        if (chkExcel.Checked) { list.Add(".xls"); list.Add(".xlsx"); }
        if (chkPdf.Checked) list.Add(".pdf");
        if (chkMp3.Checked) list.Add(".mp3");
        return list;
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        if (listResults.Items.Count == 0) return;

        using var dlg = new SaveFileDialog
        {
            Filter = "Текстовый файл (*.txt)|*.txt",
            FileName = "results.txt",
            DefaultExt = "txt"
        };

        if (dlg.ShowDialog() != DialogResult.OK) return;

        File.WriteAllLines(dlg.FileName, listResults.Items.Cast<string>());
        MessageBox.Show($"Результаты сохранены:\n{dlg.FileName}", "FileFinder",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
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

    private void btnHelp_Click(object sender, EventArgs e)
    {
        MessageBox.Show(
            "FileFinder v1.0\n\n" +
            "Программа для поиска файлов на компьютере.\n\n" +
            "1. Выберите диск для поиска\n" +
            "2. Выберите типы файлов\n" +
            "3. При необходимости введите часть имени файла в поле «Поиск»\n" +
            "4. Нажмите кнопку «Поиск»\n" +
            "5. Результаты можно сохранить в текстовый файл",
            "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
}
