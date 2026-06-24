namespace FileFinder;

public partial class ActivateLicenseDialog : Form
{
    private const string ContactEmail = "boroduliha@gmail.com";

    public ActivateLicenseDialog()
    {
        InitializeComponent();
    }

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        btnGmail.Enabled = email.Contains('@') && email.Length > 3;
    }

    private void btnGmail_Click(object sender, EventArgs e)
    {
        string userEmail = txtEmail.Text.Trim();
        string subject   = Uri.EscapeDataString("Лицензия FileFinder");
        string body      = Uri.EscapeDataString(
            $"Здравствуйте!\n\nХочу купить лицензию FileFinder ($5/год).\n" +
            $"Мой e-mail для привязки ключа: {userEmail}");
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName        = $"https://mail.google.com/mail/?view=cm&fs=1&to={ContactEmail}&su={subject}&body={body}",
            UseShellExecute = true
        });
    }

    private void btnCopyEmail_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(ContactEmail);
        btnCopyEmail.Text = "Скопировано!";
        var timer = new System.Windows.Forms.Timer { Interval = 1500 };
        timer.Tick += (_, _) => { btnCopyEmail.Text = "Копировать"; timer.Stop(); timer.Dispose(); };
        timer.Start();
    }

    private void btnActivate_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string key   = txtKey.Text.Trim();

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(key))
        {
            ShowStatus("Введите e-mail и ключ лицензии.", Color.OrangeRed);
            return;
        }

        if (!email.Contains('@'))
        {
            ShowStatus("Введите корректный e-mail.", Color.OrangeRed);
            return;
        }

        if (LicenseService.Activate(email, key, out LicenseInfo? info))
        {
            ShowStatus($"Лицензия активирована до {info!.Expiry:dd.MM.yyyy}.", Color.Green);
            btnActivate.Enabled = false;
            DialogResult = DialogResult.OK;
        }
        else
        {
            ShowStatus("Неверный ключ или e-mail. Проверьте данные из письма.", Color.OrangeRed);
        }
    }

    private void ShowStatus(string message, Color color)
    {
        lblStatus.ForeColor = color;
        lblStatus.Text      = message;
    }
}
