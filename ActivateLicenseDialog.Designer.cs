namespace FileFinder;

partial class ActivateLicenseDialog
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblEmailCaption  = new Label();
        txtEmail         = new TextBox();
        btnGmail         = new Button();
        lblOr            = new Label();
        lblCopyAddr      = new Label();
        btnCopyEmail     = new Button();
        pnlSeparator     = new Panel();
        lblKeyCaption    = new Label();
        txtKey           = new TextBox();
        lblStatus        = new Label();
        btnActivate      = new Button();
        btnClose         = new Button();
        SuspendLayout();

        // lblEmailCaption
        lblEmailCaption.AutoSize = true;
        lblEmailCaption.Location = new Point(12, 16);
        lblEmailCaption.Name     = "lblEmailCaption";
        lblEmailCaption.Text     = "E-mail:";

        // txtEmail
        txtEmail.Location        = new Point(80, 13);
        txtEmail.Size            = new Size(320, 23);
        txtEmail.Name            = "txtEmail";
        txtEmail.PlaceholderText = "ваш e-mail для лицензии";
        txtEmail.TabIndex        = 0;
        txtEmail.TextChanged    += txtEmail_TextChanged;

        // btnGmail
        btnGmail.BackColor              = Color.FromArgb(0, 120, 212);
        btnGmail.ForeColor              = Color.White;
        btnGmail.FlatStyle              = FlatStyle.Flat;
        btnGmail.FlatAppearance.BorderSize = 0;
        btnGmail.Enabled                = false;
        btnGmail.Font                   = new Font("Segoe UI", 9F);
        btnGmail.Location               = new Point(12, 46);
        btnGmail.Size                   = new Size(390, 28);
        btnGmail.Name                   = "btnGmail";
        btnGmail.TabIndex               = 1;
        btnGmail.Text                   = "Написать (Gmail) для получения ключа — $5 / год";
        btnGmail.Click                 += btnGmail_Click;

        // lblOr
        lblOr.AutoSize  = true;
        lblOr.ForeColor = SystemColors.GrayText;
        lblOr.Location  = new Point(12, 86);
        lblOr.Name      = "lblOr";
        lblOr.Text      = "или:";

        // lblCopyAddr
        lblCopyAddr.AutoSize  = true;
        lblCopyAddr.ForeColor = SystemColors.GrayText;
        lblCopyAddr.Location  = new Point(50, 86);
        lblCopyAddr.Name      = "lblCopyAddr";
        lblCopyAddr.Text      = "boroduliha@gmail.com";

        // btnCopyEmail
        btnCopyEmail.FlatStyle              = FlatStyle.Flat;
        btnCopyEmail.FlatAppearance.BorderColor = SystemColors.ControlDark;
        btnCopyEmail.Location = new Point(222, 80);
        btnCopyEmail.Size     = new Size(90, 26);
        btnCopyEmail.Name     = "btnCopyEmail";
        btnCopyEmail.TabIndex = 2;
        btnCopyEmail.Text     = "Копировать";
        btnCopyEmail.Click   += btnCopyEmail_Click;

        // pnlSeparator
        pnlSeparator.BackColor = SystemColors.ControlDark;
        pnlSeparator.Location  = new Point(12, 114);
        pnlSeparator.Size      = new Size(390, 1);
        pnlSeparator.Name      = "pnlSeparator";

        // lblKeyCaption
        lblKeyCaption.AutoSize = true;
        lblKeyCaption.Location = new Point(12, 130);
        lblKeyCaption.Name     = "lblKeyCaption";
        lblKeyCaption.Text     = "Ключ:";

        // txtKey
        txtKey.CharacterCasing  = CharacterCasing.Upper;
        txtKey.Location         = new Point(80, 127);
        txtKey.Size             = new Size(320, 23);
        txtKey.Name             = "txtKey";
        txtKey.PlaceholderText  = "BNFF-YYYYMM-XXXX-XXXX";
        txtKey.TabIndex         = 3;

        // lblStatus
        lblStatus.Location = new Point(12, 164);
        lblStatus.Size     = new Size(390, 18);
        lblStatus.Name     = "lblStatus";
        lblStatus.Text     = "";

        // btnActivate
        btnActivate.Location = new Point(200, 190);
        btnActivate.Size     = new Size(104, 28);
        btnActivate.Name     = "btnActivate";
        btnActivate.TabIndex = 4;
        btnActivate.Text     = "Активировать";
        btnActivate.Click   += btnActivate_Click;

        // btnClose
        btnClose.DialogResult = DialogResult.Cancel;
        btnClose.Location     = new Point(310, 190);
        btnClose.Size         = new Size(90, 28);
        btnClose.Name         = "btnClose";
        btnClose.TabIndex     = 5;
        btnClose.Text         = "Закрыть";

        // ActivateLicenseDialog
        AcceptButton        = btnActivate;
        CancelButton        = btnClose;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode       = AutoScaleMode.Font;
        ClientSize          = new Size(414, 234);
        FormBorderStyle     = FormBorderStyle.FixedDialog;
        MaximizeBox         = false;
        MinimizeBox         = false;
        Name                = "ActivateLicenseDialog";
        StartPosition       = FormStartPosition.CenterParent;
        Text                = "Активация лицензии";

        Controls.Add(lblEmailCaption);
        Controls.Add(txtEmail);
        Controls.Add(btnGmail);
        Controls.Add(lblOr);
        Controls.Add(lblCopyAddr);
        Controls.Add(btnCopyEmail);
        Controls.Add(pnlSeparator);
        Controls.Add(lblKeyCaption);
        Controls.Add(txtKey);
        Controls.Add(lblStatus);
        Controls.Add(btnActivate);
        Controls.Add(btnClose);

        ResumeLayout(false);
        PerformLayout();
    }

    private Label   lblEmailCaption;
    private TextBox txtEmail;
    private Button  btnGmail;
    private Label   lblOr;
    private Label   lblCopyAddr;
    private Button  btnCopyEmail;
    private Panel   pnlSeparator;
    private Label   lblKeyCaption;
    private TextBox txtKey;
    private Label   lblStatus;
    private Button  btnActivate;
    private Button  btnClose;
}
