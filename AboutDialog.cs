namespace FileFinder;

public partial class AboutDialog : Form
{
    public AboutDialog()
    {
        InitializeComponent();
        RefreshLicenseStatus();
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

    private void btnActivate_Click(object sender, EventArgs e)
    {
        using var dlg = new ActivateLicenseDialog();
        if (dlg.ShowDialog(this) == DialogResult.OK)
            RefreshLicenseStatus();
    }
}
