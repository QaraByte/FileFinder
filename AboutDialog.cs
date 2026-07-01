namespace FileFinder;

public partial class AboutDialog : Form
{
    public AboutDialog()
    {
        InitializeComponent();
        btnCopyEmail.Text = ""; // Segoe MDL2 Assets: copy icon (U+E8C8)
        ApplyLanguage();
        RefreshLicenseStatus();
        PopulateHelp();
    }

    private void ApplyLanguage()
    {
        tabAbout.Text  = Lang.TabAbout;
        tabHelp.Text   = Lang.TabHelp;
        lblAuthor.Text = Lang.AboutAuthor;
    }

    private void PopulateHelp()
    {
        txtHelp.Clear();

        void Section(string header, string body)
        {
            txtHelp.AppendText(header + "\r\n");
            txtHelp.AppendText(body + "\r\n\r\n");
        }

        Section(Lang.HelpFileTypes,  Lang.HelpFileTypesBody);
        Section(Lang.HelpDrive,      Lang.HelpDriveBody);
        Section(Lang.HelpSearch,     Lang.HelpSearchBody);
        Section(Lang.HelpResults,    Lang.HelpResultsBody);
        Section(Lang.HelpFilter,     Lang.HelpFilterBody);
        Section(Lang.HelpSave,       Lang.HelpSaveBody);

        int headerStart = txtHelp.TextLength;
        txtHelp.AppendText(Lang.HelpProHeader + "\r\n");
        txtHelp.Select(headerStart, Lang.HelpProHeader.Length);
        txtHelp.SelectionColor = Color.OrangeRed;
        using var boldFont = new Font(txtHelp.Font, FontStyle.Bold);
        txtHelp.SelectionFont = boldFont;
        txtHelp.Select(txtHelp.TextLength, 0);
        txtHelp.SelectionColor = txtHelp.ForeColor;
        txtHelp.SelectionFont  = txtHelp.Font;
        txtHelp.AppendText(Lang.HelpProBody);
    }

    private void RefreshLicenseStatus()
    {
        var lic = LicenseService.Current;
        if (lic == null)
        {
            lblLicenseStatus.Text      = Lang.LicNotActivated;
            lblLicenseStatus.ForeColor = SystemColors.GrayText;
            btnActivate.Text           = Lang.BtnActivateLic;
        }
        else if (lic.IsActive)
        {
            lblLicenseStatus.Text      = Lang.LicActive(lic.Expiry);
            lblLicenseStatus.ForeColor = Color.Green;
            btnActivate.Text           = Lang.BtnChangeLic;
        }
        else
        {
            lblLicenseStatus.Text      = Lang.LicExpired(lic.Expiry);
            lblLicenseStatus.ForeColor = Color.OrangeRed;
            btnActivate.Text           = Lang.BtnRenewLic;
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
