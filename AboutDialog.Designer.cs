namespace FileFinder;

partial class AboutDialog
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null)
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        tabMain          = new TabControl();
        tabAbout         = new TabPage();
        tabHelp          = new TabPage();
        lblAppName       = new Label();
        lblCopyright     = new Label();
        txtHistory       = new RichTextBox();
        lblAuthor        = new Label();
        pnlEmail         = new Panel();
        lblEmail         = new Label();
        btnCopyEmail     = new Button();
        pnlSeparator     = new Panel();
        pnlLicense       = new Panel();
        lblLicenseStatus = new Label();
        btnActivate      = new Button();
        txtHelp          = new RichTextBox();
        pnlBottom        = new Panel();
        btnOk            = new Button();

        tabMain.SuspendLayout();
        tabAbout.SuspendLayout();
        tabHelp.SuspendLayout();
        pnlEmail.SuspendLayout();
        pnlLicense.SuspendLayout();
        pnlBottom.SuspendLayout();
        SuspendLayout();

        // tabMain
        tabMain.Controls.Add(tabAbout);
        tabMain.Controls.Add(tabHelp);
        tabMain.Dock          = DockStyle.Fill;
        tabMain.Name          = "tabMain";
        tabMain.SelectedIndex = 0;
        tabMain.TabIndex      = 0;

        // tabAbout — controls in reverse Dock=Top order (last added = top)
        tabAbout.Name = "tabAbout";
        tabAbout.Text = "О программе";
        tabAbout.UseVisualStyleBackColor = true;
        tabAbout.Controls.Add(pnlLicense);
        tabAbout.Controls.Add(lblLicenseStatus);
        tabAbout.Controls.Add(pnlSeparator);
        tabAbout.Controls.Add(pnlEmail);
        tabAbout.Controls.Add(lblAuthor);
        tabAbout.Controls.Add(txtHistory);
        tabAbout.Controls.Add(lblCopyright);
        tabAbout.Controls.Add(lblAppName);

        // tabHelp
        tabHelp.Name    = "tabHelp";
        tabHelp.Padding = new Padding(6);
        tabHelp.Text    = "Справка";
        tabHelp.UseVisualStyleBackColor = true;
        tabHelp.Controls.Add(txtHelp);

        // lblAppName
        lblAppName.AutoSize  = false;
        lblAppName.Dock      = DockStyle.Top;
        lblAppName.Font      = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblAppName.Height    = 44;
        lblAppName.Name      = "lblAppName";
        lblAppName.Text      = "FileFinder";
        lblAppName.TextAlign = ContentAlignment.MiddleCenter;

        // lblCopyright
        lblCopyright.AutoSize  = false;
        lblCopyright.Dock      = DockStyle.Top;
        lblCopyright.Font      = new Font("Segoe UI", 9F);
        lblCopyright.ForeColor = SystemColors.GrayText;
        lblCopyright.Height    = 22;
        lblCopyright.Name      = "lblCopyright";
        lblCopyright.Text      = "© BN Software, 2017–2026";
        lblCopyright.TextAlign = ContentAlignment.MiddleCenter;

        // txtHistory
        txtHistory.BackColor   = SystemColors.Control;
        txtHistory.BorderStyle = BorderStyle.None;
        txtHistory.Dock        = DockStyle.Top;
        txtHistory.Font        = new Font("Segoe UI", 9F);
        txtHistory.Height      = 160;
        txtHistory.Name        = "txtHistory";
        txtHistory.ReadOnly    = true;
        txtHistory.ScrollBars  = RichTextBoxScrollBars.Vertical;
        txtHistory.TabStop     = false;
        txtHistory.Text =
            "Версия 1.00 / 15.02.2017\r\n" +
            "Поиск файлов различных форматов (*.txt, *.doc, *.docx)\r\n" +
            "в каталогах пятого уровня на диске C.\r\n" +
            "\r\n" +
            "Версия 1.01 / 16.02.2017\r\n" +
            "- добавлены иконки файлов (Word, Excel, pdf)\r\n" +
            "- добавился поиск документов Microsoft Excel\r\n" +
            "- редизайн «Типов файлов»\r\n" +
            "- изменено окно «О программе»\r\n" +
            "\r\n" +
            "Версия 2.00 / 2026\r\n" +
            "- Полная переработка приложения\r\n" +
            "- Поддержка новых форматов: PDF, MP3, PowerPoint, изображения\r\n" +
            "- Лицензионная система Pro\r\n" +
            "- Добавлена справка\r\n" +
            "- Английский язык (в разработке)";

        // lblAuthor
        lblAuthor.AutoSize  = false;
        lblAuthor.Dock      = DockStyle.Top;
        lblAuthor.Font      = new Font("Segoe UI", 9F);
        lblAuthor.Height    = 22;
        lblAuthor.Name      = "lblAuthor";
        lblAuthor.Padding   = new Padding(6, 0, 0, 0);
        lblAuthor.Text      = "Автор: N.Bexatov";
        lblAuthor.TextAlign = ContentAlignment.MiddleLeft;

        // lblEmail — fixed width so button sits right next to it
        lblEmail.AutoSize  = false;
        lblEmail.Font      = new Font("Segoe UI", 9F);
        lblEmail.Location  = new Point(0, 0);
        lblEmail.Name      = "lblEmail";
        lblEmail.Padding   = new Padding(6, 0, 0, 0);
        lblEmail.Size      = new Size(188, 26);
        lblEmail.Text      = "E-mail: boroduliha@gmail.com";
        lblEmail.TextAlign = ContentAlignment.MiddleLeft;

        // btnCopyEmail — positioned right after the email text
        btnCopyEmail.Font     = new Font("Segoe MDL2 Assets", 9F);
        btnCopyEmail.Location = new Point(190, 2);
        btnCopyEmail.Name     = "btnCopyEmail";
        btnCopyEmail.Size     = new Size(22, 22);
        btnCopyEmail.TabIndex = 0;
        btnCopyEmail.Text     = "";
        btnCopyEmail.UseVisualStyleBackColor = true;
        btnCopyEmail.Click   += btnCopyEmail_Click;

        // pnlEmail
        pnlEmail.Controls.Add(btnCopyEmail);
        pnlEmail.Controls.Add(lblEmail);
        pnlEmail.Dock   = DockStyle.Top;
        pnlEmail.Height = 26;
        pnlEmail.Name   = "pnlEmail";

        // pnlSeparator
        pnlSeparator.BackColor = SystemColors.ControlDark;
        pnlSeparator.Dock      = DockStyle.Top;
        pnlSeparator.Height    = 1;
        pnlSeparator.Name      = "pnlSeparator";

        // lblLicenseStatus
        lblLicenseStatus.AutoSize = false;
        lblLicenseStatus.Dock     = DockStyle.Top;
        lblLicenseStatus.Font     = new Font("Segoe UI", 9F);
        lblLicenseStatus.Height   = 24;
        lblLicenseStatus.Name     = "lblLicenseStatus";
        lblLicenseStatus.Padding  = new Padding(6, 4, 0, 0);
        lblLicenseStatus.Text     = "Лицензия: не активирована";

        // btnActivate
        btnActivate.Location = new Point(6, 2);
        btnActivate.Name     = "btnActivate";
        btnActivate.Size     = new Size(180, 26);
        btnActivate.TabIndex = 0;
        btnActivate.Text     = "Активировать лицензию...";
        btnActivate.Click   += btnActivate_Click;

        // pnlLicense
        pnlLicense.Controls.Add(btnActivate);
        pnlLicense.Dock   = DockStyle.Top;
        pnlLicense.Height = 34;
        pnlLicense.Name   = "pnlLicense";

        // txtHelp — populated in code (AboutDialog.cs) for colored text support
        txtHelp.BackColor   = SystemColors.Control;
        txtHelp.BorderStyle = BorderStyle.None;
        txtHelp.Dock        = DockStyle.Fill;
        txtHelp.Font        = new Font("Segoe UI", 9F);
        txtHelp.Name        = "txtHelp";
        txtHelp.ReadOnly    = true;
        txtHelp.ScrollBars  = RichTextBoxScrollBars.Vertical;
        txtHelp.TabStop     = false;

        // btnOk
        btnOk.Anchor       = AnchorStyles.Right | AnchorStyles.Bottom;
        btnOk.DialogResult = DialogResult.OK;
        btnOk.Location     = new Point(306, 9);
        btnOk.Name         = "btnOk";
        btnOk.Size         = new Size(80, 26);
        btnOk.Text         = "OK";

        // pnlBottom
        pnlBottom.Controls.Add(btnOk);
        pnlBottom.Dock   = DockStyle.Bottom;
        pnlBottom.Height = 44;
        pnlBottom.Name   = "pnlBottom";

        // AboutDialog
        // pnlBottom added last → takes bottom 44px; tabMain fills the rest
        AcceptButton        = btnOk;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode       = AutoScaleMode.Font;
        ClientSize          = new Size(394, 430);
        FormBorderStyle     = FormBorderStyle.FixedDialog;
        MaximizeBox         = false;
        MinimizeBox         = false;
        Name                = "AboutDialog";
        StartPosition       = FormStartPosition.CenterParent;
        Text                = "О программе";

        Controls.Add(tabMain);
        Controls.Add(pnlBottom);

        pnlEmail.ResumeLayout(false);
        pnlLicense.ResumeLayout(false);
        tabAbout.ResumeLayout(false);
        tabHelp.ResumeLayout(false);
        tabMain.ResumeLayout(false);
        pnlBottom.ResumeLayout(false);
        ResumeLayout(false);
        PerformLayout();
    }

    private Label        lblAppName;
    private Label        lblCopyright;
    private RichTextBox  txtHistory;
    private Label        lblAuthor;
    private Panel        pnlEmail;
    private Label        lblEmail;
    private Button       btnCopyEmail;
    private Panel        pnlSeparator;
    private Label        lblLicenseStatus;
    private Button       btnActivate;
    private Panel        pnlLicense;
    private Button       btnOk;
    private TabControl   tabMain;
    private TabPage      tabAbout;
    private TabPage      tabHelp;
    private RichTextBox  txtHelp;
    private Panel        pnlBottom;
}
