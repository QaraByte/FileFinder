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
        lblInstruction = new Label();
        lblEmailCaption = new Label();
        txtEmail = new TextBox();
        lblKeyCaption = new Label();
        txtKey = new TextBox();
        lblStatus = new Label();
        btnActivate = new Button();
        btnClose = new Button();
        SuspendLayout();

        // lblInstruction
        lblInstruction.Location  = new Point(12, 14);
        lblInstruction.Size      = new Size(390, 18);
        lblInstruction.Text      = "Введите e-mail и ключ лицензии из письма:";
        lblInstruction.Name      = "lblInstruction";

        // lblEmailCaption
        lblEmailCaption.AutoSize = true;
        lblEmailCaption.Location = new Point(12, 44);
        lblEmailCaption.Text     = "E-mail:";
        lblEmailCaption.Name     = "lblEmailCaption";

        // txtEmail
        txtEmail.Location        = new Point(80, 41);
        txtEmail.Size            = new Size(320, 23);
        txtEmail.Name            = "txtEmail";
        txtEmail.PlaceholderText = "buyer@example.com";
        txtEmail.TabIndex        = 0;

        // lblKeyCaption
        lblKeyCaption.AutoSize   = true;
        lblKeyCaption.Location   = new Point(12, 78);
        lblKeyCaption.Text       = "Ключ:";
        lblKeyCaption.Name       = "lblKeyCaption";

        // txtKey
        txtKey.CharacterCasing  = CharacterCasing.Upper;
        txtKey.Location         = new Point(80, 75);
        txtKey.Size             = new Size(320, 23);
        txtKey.Name             = "txtKey";
        txtKey.PlaceholderText  = "BNFF-YYYYMM-XXXX-XXXX";
        txtKey.TabIndex         = 1;

        // lblStatus
        lblStatus.Location      = new Point(12, 112);
        lblStatus.Size          = new Size(390, 18);
        lblStatus.Name          = "lblStatus";
        lblStatus.Text          = "";

        // btnActivate
        btnActivate.Location    = new Point(214, 140);
        btnActivate.Size        = new Size(90, 28);
        btnActivate.Text        = "Активировать";
        btnActivate.TabIndex    = 2;
        btnActivate.Click      += btnActivate_Click;

        // btnClose
        btnClose.DialogResult   = DialogResult.Cancel;
        btnClose.Location       = new Point(310, 140);
        btnClose.Size           = new Size(90, 28);
        btnClose.Text           = "Закрыть";
        btnClose.TabIndex       = 3;

        // ActivateLicenseDialog
        AcceptButton           = btnActivate;
        CancelButton           = btnClose;
        AutoScaleDimensions    = new SizeF(7F, 15F);
        AutoScaleMode          = AutoScaleMode.Font;
        ClientSize             = new Size(414, 184);
        FormBorderStyle        = FormBorderStyle.FixedDialog;
        MaximizeBox            = false;
        MinimizeBox            = false;
        Name                   = "ActivateLicenseDialog";
        StartPosition          = FormStartPosition.CenterParent;
        Text                   = "Активация лицензии";

        Controls.Add(lblInstruction);
        Controls.Add(lblEmailCaption);
        Controls.Add(txtEmail);
        Controls.Add(lblKeyCaption);
        Controls.Add(txtKey);
        Controls.Add(lblStatus);
        Controls.Add(btnActivate);
        Controls.Add(btnClose);

        ResumeLayout(false);
        PerformLayout();
    }

    private Label   lblInstruction;
    private Label   lblEmailCaption;
    private TextBox txtEmail;
    private Label   lblKeyCaption;
    private TextBox txtKey;
    private Label   lblStatus;
    private Button  btnActivate;
    private Button  btnClose;
}
