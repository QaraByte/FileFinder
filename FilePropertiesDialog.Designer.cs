namespace FileFinder;

partial class FilePropertiesDialog
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
        tableLayout = new TableLayoutPanel();
        lblName = new Label();
        lblNameValue = new Label();
        lblPath = new Label();
        txtPathValue = new TextBox();
        lblSize = new Label();
        lblSizeValue = new Label();
        lblAuthor = new Label();
        lblAuthorValue = new Label();
        lblCreated = new Label();
        lblCreatedValue = new Label();
        btnOk = new Button();

        tableLayout.SuspendLayout();
        SuspendLayout();

        // tableLayout
        tableLayout.ColumnCount = 2;
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110F));
        tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
        tableLayout.RowCount = 5;
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
        tableLayout.Controls.Add(lblName, 0, 0);
        tableLayout.Controls.Add(lblNameValue, 1, 0);
        tableLayout.Controls.Add(lblPath, 0, 1);
        tableLayout.Controls.Add(txtPathValue, 1, 1);
        tableLayout.Controls.Add(lblSize, 0, 2);
        tableLayout.Controls.Add(lblSizeValue, 1, 2);
        tableLayout.Controls.Add(lblAuthor, 0, 3);
        tableLayout.Controls.Add(lblAuthorValue, 1, 3);
        tableLayout.Controls.Add(lblCreated, 0, 4);
        tableLayout.Controls.Add(lblCreatedValue, 1, 4);
        tableLayout.Dock = DockStyle.Top;
        tableLayout.Location = new Point(12, 12);
        tableLayout.Padding = new Padding(0, 4, 0, 4);
        tableLayout.Size = new Size(456, 180);
        tableLayout.Name = "tableLayout";

        // caption labels (right column)
        foreach (Label lbl in new[] { lblName, lblPath, lblSize, lblAuthor, lblCreated })
        {
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lbl.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Margin = new Padding(3, 10, 3, 0);
        }

        lblName.Text = "Название:";
        lblPath.Text = "Путь:";
        lblSize.Text = "Размер:";
        lblAuthor.Text = "Автор:";
        lblCreated.Text = "Создан:";

        // value labels
        foreach (Label lbl in new[] { lblNameValue, lblSizeValue, lblAuthorValue, lblCreatedValue })
        {
            lbl.Anchor = AnchorStyles.Left | AnchorStyles.Top;
            lbl.AutoSize = true;
            lbl.Margin = new Padding(3, 10, 3, 0);
            lbl.MaximumSize = new Size(330, 0);
        }

        // txtPathValue — read-only TextBox so user can copy the path
        txtPathValue.Anchor = AnchorStyles.Left | AnchorStyles.Right;
        txtPathValue.BackColor = SystemColors.Control;
        txtPathValue.BorderStyle = BorderStyle.None;
        txtPathValue.Margin = new Padding(3, 10, 3, 0);
        txtPathValue.ReadOnly = true;
        txtPathValue.TabStop = false;

        // btnOk
        btnOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnOk.DialogResult = DialogResult.OK;
        btnOk.Location = new Point(393, 208);
        btnOk.Size = new Size(75, 26);
        btnOk.Text = "OK";
        btnOk.Name = "btnOk";

        // FilePropertiesDialog
        AcceptButton = btnOk;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(480, 246);
        Controls.Add(tableLayout);
        Controls.Add(btnOk);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        MinimizeBox = false;
        Name = "FilePropertiesDialog";
        Padding = new Padding(12);
        StartPosition = FormStartPosition.CenterParent;
        Text = "Свойства файла";

        tableLayout.ResumeLayout(false);
        tableLayout.PerformLayout();
        ResumeLayout(false);
    }

    private TableLayoutPanel tableLayout;
    private Label lblName;
    private Label lblNameValue;
    private Label lblPath;
    private TextBox txtPathValue;
    private Label lblSize;
    private Label lblSizeValue;
    private Label lblAuthor;
    private Label lblAuthorValue;
    private Label lblCreated;
    private Label lblCreatedValue;
    private Button btnOk;
}
