namespace FileFinder;

public partial class AboutDialog : Form
{
    public AboutDialog()
    {
        InitializeComponent();
        btnCopyEmail.Text = ""; // Segoe MDL2 Assets: copy icon
        RefreshLicenseStatus();
        PopulateHelp();
    }

    private void PopulateHelp()
    {
        txtHelp.Clear();

        void Section(string header, string body)
        {
            txtHelp.AppendText(header + "\r\n");
            txtHelp.AppendText(body + "\r\n\r\n");
        }

        Section("Выбор типов файлов",
            "Отметьте нужные форматы в блоке «Типы файлов» (*.txt, *.doc, *.pdf и др.).");

        Section("Выбор диска",
            "В поле «Искать на:» выберите диск для поиска. Кнопка ↻ обновляет список подключённых дисков.");

        Section("Поиск",
            "Нажмите «Поиск» — программа рекурсивно просканирует все папки выбранного диска. " +
            "Во время поиска кнопка меняется на «Стоп» — нажмите для остановки.");

        Section("Список результатов",
            "Найденные файлы отображаются в списке результатов (большая область вверху окна):\r\n" +
            "  • двойной клик — открыть файл\r\n" +
            "  • правый клик — открывается контекстное меню (Открыть, Открыть папку, Свойства)");

        Section("Фильтр по имени",
            "Поле «Поиск:» фильтрует список результатов по имени файла в реальном времени, без повторного поиска.");

        Section("Сохранить результаты",
            "Кнопка «Сохранить результаты» сохраняет список в текстовый файл.");

        // "Лицензия Pro" — выделяем цветом и жирным
        int headerStart = txtHelp.TextLength;
        txtHelp.AppendText("Лицензия Pro\r\n");
        txtHelp.Select(headerStart, "Лицензия Pro".Length);
        txtHelp.SelectionColor = Color.OrangeRed;
        using var boldFont = new Font(txtHelp.Font, FontStyle.Bold);
        txtHelp.SelectionFont = boldFont;
        txtHelp.Select(txtHelp.TextLength, 0);
        txtHelp.SelectionColor = txtHelp.ForeColor;
        txtHelp.SelectionFont = txtHelp.Font;
        txtHelp.AppendText("Открывает дополнительные форматы: PDF, MP3, PowerPoint, изображения (JPG, PNG, GIF, BMP).");
    }

    private void RefreshLicenseStatus()
    {
        var lic = LicenseService.Current;
        if (lic == null)
        {
            lblLicenseStatus.Text      = "Лицензия: не активирована";
            lblLicenseStatus.ForeColor = SystemColors.GrayText;
            btnActivate.Text           = "Активировать лицензию...";
        }
        else if (lic.IsActive)
        {
            lblLicenseStatus.Text      = $"Лицензия: активна до {lic.Expiry:dd.MM.yyyy}";
            lblLicenseStatus.ForeColor = Color.Green;
            btnActivate.Text           = "Сменить лицензию...";
        }
        else
        {
            lblLicenseStatus.Text      = $"Лицензия: истекла {lic.Expiry:dd.MM.yyyy} — продлите подписку";
            lblLicenseStatus.ForeColor = Color.OrangeRed;
            btnActivate.Text           = "Продлить лицензию...";
        }
    }

    private void btnCopyEmail_Click(object sender, EventArgs e)
    {
        Clipboard.SetText("boroduliha@gmail.com");
    }

    private void btnActivate_Click(object sender, EventArgs e)
    {
        using var dlg = new ActivateLicenseDialog();
        if (dlg.ShowDialog(this) == DialogResult.OK)
            RefreshLicenseStatus();
    }
}
