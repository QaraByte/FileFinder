namespace FileFinder;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
            components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        listResults = new ListBox();
        contextMenu = new ContextMenuStrip(components);
        menuOpen = new ToolStripMenuItem();
        menuOpenFolder = new ToolStripMenuItem();
        menuSeparator = new ToolStripSeparator();
        menuProperties = new ToolStripMenuItem();
        lblFound = new Label();
        lblDrive = new Label();
        cmbDrive = new ComboBox();
        lblSearch = new Label();
        txtSearch = new TextBox();
        grpFileTypes = new GroupBox();
        chkTxt = new CheckBox();
        chkWord = new CheckBox();
        chkExcel = new CheckBox();
        chkPdf = new CheckBox();
        chkMp3 = new CheckBox();
        btnSearch = new Button();
        btnSave = new Button();
        btnHelp = new Button();
        contextMenu.SuspendLayout();
        grpFileTypes.SuspendLayout();
        SuspendLayout();
        // 
        // listResults
        // 
        listResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        listResults.ContextMenuStrip = contextMenu;
        listResults.Font = new Font("Segoe UI", 9F);
        listResults.FormattingEnabled = true;
        listResults.HorizontalScrollbar = true;
        listResults.Location = new Point(12, 12);
        listResults.Name = "listResults";
        listResults.Size = new Size(910, 394);
        listResults.TabIndex = 0;
        listResults.DoubleClick += listResults_DoubleClick;
        // 
        // contextMenu
        // 
        contextMenu.Items.AddRange(new ToolStripItem[] { menuOpen, menuOpenFolder, menuSeparator, menuProperties });
        contextMenu.Name = "contextMenu";
        contextMenu.Size = new Size(181, 98);
        // 
        // menuOpen
        // 
        menuOpen.Name = "menuOpen";
        menuOpen.Size = new Size(180, 22);
        menuOpen.Text = "Открыть";
        menuOpen.Click += menuOpen_Click;
        // 
        // menuOpenFolder
        // 
        menuOpenFolder.Image = Properties.Resources.wpcmon;
        menuOpenFolder.Name = "menuOpenFolder";
        menuOpenFolder.Size = new Size(180, 22);
        menuOpenFolder.Text = "Открыть папку";
        menuOpenFolder.Click += menuOpenFolder_Click;
        // 
        // menuSeparator
        // 
        menuSeparator.Name = "menuSeparator";
        menuSeparator.Size = new Size(177, 6);
        // 
        // menuProperties
        // 
        menuProperties.Name = "menuProperties";
        menuProperties.Size = new Size(180, 22);
        menuProperties.Text = "Свойства";
        menuProperties.Click += menuProperties_Click;
        // 
        // lblFound
        // 
        lblFound.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblFound.AutoSize = true;
        lblFound.Location = new Point(12, 422);
        lblFound.Name = "lblFound";
        lblFound.Size = new Size(58, 15);
        lblFound.TabIndex = 1;
        lblFound.Text = "Найдено:";
        // 
        // lblDrive
        // 
        lblDrive.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        lblDrive.AutoSize = true;
        lblDrive.Location = new Point(726, 422);
        lblDrive.Name = "lblDrive";
        lblDrive.Size = new Size(64, 15);
        lblDrive.TabIndex = 2;
        lblDrive.Text = "Искать на:";
        // 
        // cmbDrive
        // 
        cmbDrive.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        cmbDrive.DropDownStyle = ComboBoxStyle.DropDownList;
        cmbDrive.Location = new Point(804, 418);
        cmbDrive.Name = "cmbDrive";
        cmbDrive.Size = new Size(118, 23);
        cmbDrive.TabIndex = 1;
        // 
        // lblSearch
        // 
        lblSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(12, 456);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(45, 15);
        lblSearch.TabIndex = 3;
        lblSearch.Text = "Поиск:";
        // 
        // txtSearch
        // 
        txtSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        txtSearch.Location = new Point(64, 452);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(258, 23);
        txtSearch.TabIndex = 2;
        // 
        // grpFileTypes
        // 
        grpFileTypes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        grpFileTypes.Controls.Add(chkTxt);
        grpFileTypes.Controls.Add(chkWord);
        grpFileTypes.Controls.Add(chkExcel);
        grpFileTypes.Controls.Add(chkPdf);
        grpFileTypes.Controls.Add(chkMp3);
        grpFileTypes.Location = new Point(12, 484);
        grpFileTypes.Name = "grpFileTypes";
        grpFileTypes.Size = new Size(318, 178);
        grpFileTypes.TabIndex = 3;
        grpFileTypes.TabStop = false;
        grpFileTypes.Text = "Типы файлов";
        // 
        // chkTxt
        // 
        chkTxt.AutoSize = true;
        chkTxt.Location = new Point(10, 26);
        chkTxt.Name = "chkTxt";
        chkTxt.Size = new Size(157, 19);
        chkTxt.TabIndex = 0;
        chkTxt.Text = "Текстовые файлы (*.txt)";
        // 
        // chkWord
        // 
        chkWord.AutoSize = true;
        chkWord.Location = new Point(10, 56);
        chkWord.Name = "chkWord";
        chkWord.Size = new Size(253, 19);
        chkWord.TabIndex = 1;
        chkWord.Text = "Документы Microsoft Word (*.doc, *.docx)";
        // 
        // chkExcel
        // 
        chkExcel.AutoSize = true;
        chkExcel.Location = new Point(10, 86);
        chkExcel.Name = "chkExcel";
        chkExcel.Size = new Size(236, 19);
        chkExcel.TabIndex = 2;
        chkExcel.Text = "Документы Microsoft Excel (*.xls, *.xlsx)";
        // 
        // chkPdf
        // 
        chkPdf.AutoSize = true;
        chkPdf.Location = new Point(10, 116);
        chkPdf.Name = "chkPdf";
        chkPdf.Size = new Size(150, 19);
        chkPdf.TabIndex = 3;
        chkPdf.Text = "Документы PDF (*.pdf)";
        // 
        // chkMp3
        // 
        chkMp3.AutoSize = true;
        chkMp3.Location = new Point(10, 146);
        chkMp3.Name = "chkMp3";
        chkMp3.Size = new Size(139, 19);
        chkMp3.TabIndex = 4;
        chkMp3.Text = "Музыка mp3 (*.mp3)";
        // 
        // btnSearch
        // 
        btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSearch.Location = new Point(348, 510);
        btnSearch.Name = "btnSearch";
        btnSearch.Size = new Size(140, 52);
        btnSearch.TabIndex = 4;
        btnSearch.Text = "Поиск";
        btnSearch.Click += btnSearch_Click;
        // 
        // btnSave
        // 
        btnSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSave.Enabled = false;
        btnSave.Location = new Point(348, 572);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(140, 28);
        btnSave.TabIndex = 5;
        btnSave.Text = "Сохранить результаты";
        btnSave.Click += btnSave_Click;
        // 
        // btnHelp
        // 
        btnHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnHelp.Location = new Point(878, 634);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new Size(44, 28);
        btnHelp.TabIndex = 6;
        btnHelp.Text = "?";
        btnHelp.Click += btnHelp_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(934, 674);
        Controls.Add(listResults);
        Controls.Add(lblFound);
        Controls.Add(lblDrive);
        Controls.Add(cmbDrive);
        Controls.Add(lblSearch);
        Controls.Add(txtSearch);
        Controls.Add(grpFileTypes);
        Controls.Add(btnSearch);
        Controls.Add(btnSave);
        Controls.Add(btnHelp);
        MinimumSize = new Size(700, 600);
        Name = "MainForm";
        Text = "FileFinder";
        contextMenu.ResumeLayout(false);
        grpFileTypes.ResumeLayout(false);
        grpFileTypes.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private ListBox listResults;
    private ContextMenuStrip contextMenu;
    private ToolStripMenuItem menuOpen;
    private ToolStripMenuItem menuOpenFolder;
    private ToolStripSeparator menuSeparator;
    private ToolStripMenuItem menuProperties;
    private Label lblFound;
    private Label lblDrive;
    private ComboBox cmbDrive;
    private Label lblSearch;
    private TextBox txtSearch;
    private GroupBox grpFileTypes;
    private CheckBox chkTxt;
    private CheckBox chkWord;
    private CheckBox chkExcel;
    private CheckBox chkPdf;
    private CheckBox chkMp3;
    private Button btnSearch;
    private Button btnSave;
    private Button btnHelp;
}
