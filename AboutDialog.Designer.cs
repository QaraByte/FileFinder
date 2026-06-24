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
        lblAppName   = new Label();
        lblCopyright = new Label();
        txtHistory   = new RichTextBox();
        lblAuthor    = new Label();
        lblEmail     = new Label();
        btnOk        = new Button();
        SuspendLayout();

        // lblAppName
        lblAppName.AutoSize  = false;
        lblAppName.Dock      = DockStyle.Top;
        lblAppName.Font      = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblAppName.Height    = 48;
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
        txtHistory.Height      = 166;
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
            "Полная переработка: C#, .NET 10, WinForms.";

        // lblAuthor
        lblAuthor.AutoSize  = false;
        lblAuthor.Dock      = DockStyle.Top;
        lblAuthor.Font      = new Font("Segoe UI", 9F);
        lblAuthor.Height    = 22;
        lblAuthor.Name      = "lblAuthor";
        lblAuthor.Padding   = new Padding(6, 0, 0, 0);
        lblAuthor.Text      = "Автор: Н. Бексатов";
        lblAuthor.TextAlign = ContentAlignment.MiddleLeft;

        // lblEmail
        lblEmail.AutoSize  = false;
        lblEmail.Dock      = DockStyle.Top;
        lblEmail.Font      = new Font("Segoe UI", 9F);
        lblEmail.Height    = 22;
        lblEmail.Name      = "lblEmail";
        lblEmail.Padding   = new Padding(6, 0, 0, 0);
        lblEmail.Text      = "E-mail: pchelpkz16@gmail.com";
        lblEmail.TextAlign = ContentAlignment.MiddleLeft;

        // btnOk
        btnOk.Anchor       = AnchorStyles.Bottom | AnchorStyles.Right;
        btnOk.DialogResult = DialogResult.OK;
        btnOk.Location     = new Point(302, 320);
        btnOk.Name         = "btnOk";
        btnOk.Size         = new Size(80, 26);
        btnOk.Text         = "OK";

        // AboutDialog
        AcceptButton          = btnOk;
        AutoScaleDimensions   = new SizeF(7F, 15F);
        AutoScaleMode         = AutoScaleMode.Font;
        ClientSize            = new Size(394, 358);
        FormBorderStyle       = FormBorderStyle.FixedDialog;
        MaximizeBox           = false;
        MinimizeBox           = false;
        Name                  = "AboutDialog";
        Padding               = new Padding(8);
        StartPosition         = FormStartPosition.CenterParent;
        Text                  = "О программе";

        // add in reverse dock order (Top controls stack top-to-bottom)
        Controls.Add(btnOk);
        Controls.Add(lblEmail);
        Controls.Add(lblAuthor);
        Controls.Add(txtHistory);
        Controls.Add(lblCopyright);
        Controls.Add(lblAppName);

        ResumeLayout(false);
    }

    private Label      lblAppName;
    private Label      lblCopyright;
    private RichTextBox txtHistory;
    private Label      lblAuthor;
    private Label      lblEmail;
    private Button     btnOk;
}
