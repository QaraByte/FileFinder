namespace FileFinder;

public partial class ActivateLicenseDialog : Form
{
    public ActivateLicenseDialog()
    {
        InitializeComponent();
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
        lblStatus.Text = message;
    }
}
