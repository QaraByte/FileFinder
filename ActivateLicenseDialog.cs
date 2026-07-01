namespace FileFinder;

public partial class ActivateLicenseDialog : Form
{
    private const string ContactEmail = "boroduliha@gmail.com";

    public ActivateLicenseDialog()
    {
        InitializeComponent();
        ApplyLanguage();
    }

    private void ApplyLanguage()
    {
        Text                     = Lang.ActTitle;
        txtEmail.PlaceholderText = Lang.ActEmailPlaceholder;
        btnGmail.Text            = Lang.ActBtnGmail;
        lblOr.Text               = Lang.ActOr;
        lblKeyCaption.Text       = Lang.ActKeyCaption;
        btnActivate.Text         = Lang.ActBtnActivate;
        btnClose.Text            = Lang.ActBtnClose;
        btnCopyEmail.Text        = Lang.ActBtnCopy;
    }

    private void txtEmail_TextChanged(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        btnGmail.Enabled = email.Contains('@') && email.Length > 3;
    }

    private void btnGmail_Click(object sender, EventArgs e)
    {
        string userEmail = txtEmail.Text.Trim();
        string subject   = Uri.EscapeDataString(Lang.ActGmailSubject);
        string body      = Uri.EscapeDataString(Lang.ActGmailBody(userEmail));
        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
        {
            FileName        = $"https://mail.google.com/mail/?view=cm&fs=1&to={ContactEmail}&su={subject}&body={body}",
            UseShellExecute = true
        });
    }

    private void btnCopyEmail_Click(object sender, EventArgs e)
    {
        Clipboard.SetText(ContactEmail);
        btnCopyEmail.Text = Lang.ActCopied;
        var timer = new System.Windows.Forms.Timer { Interval = 1500 };
        timer.Tick += (_, _) => { btnCopyEmail.Text = Lang.ActBtnCopy; timer.Stop(); timer.Dispose(); };
        timer.Start();
    }

    private void btnActivate_Click(object sender, EventArgs e)
    {
        string email = txtEmail.Text.Trim();
        string key   = txtKey.Text.Trim();

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(key))
        {
            ShowStatus(Lang.ActErrNoData, Color.OrangeRed);
            return;
        }

        if (!email.Contains('@'))
        {
            ShowStatus(Lang.ActErrBadEmail, Color.OrangeRed);
            return;
        }

        if (LicenseService.Activate(email, key, out LicenseInfo? info))
        {
            ShowStatus(Lang.ActSuccess(info!.Expiry), Color.Green);
            btnActivate.Enabled = false;
            DialogResult = DialogResult.OK;
        }
        else
        {
            ShowStatus(Lang.ActErrBadKey, Color.OrangeRed);
        }
    }

    private void ShowStatus(string message, Color color)
    {
        lblStatus.ForeColor = color;
        lblStatus.Text      = message;
    }
}
