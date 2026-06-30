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
        btnRefreshDrives = new Button();
        lblSearch = new Label();
        txtSearch = new TextBox();
        grpFileTypes = new GroupBox();
        picTxt = new PictureBox();
        picWord = new PictureBox();
        picExcel = new PictureBox();
        picPdf = new PictureBox();
        picMp3 = new PictureBox();
        picPpt = new PictureBox();
        picImg = new PictureBox();
        chkTxt = new CheckBox();
        chkWord = new CheckBox();
        chkExcel = new CheckBox();
        chkPdf = new CheckBox();
        chkMp3 = new CheckBox();
        chkPpt = new CheckBox();
        chkImg = new CheckBox();
        lblLicenseNotice = new Label();
        btnSearch = new Button();
        btnSave = new Button();
        btnHelp = new Button();
        statusBar = new StatusStrip();
        statusLabel = new ToolStripStatusLabel();
        contextMenu.SuspendLayout();
        grpFileTypes.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)picTxt).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picWord).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picExcel).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picPdf).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picMp3).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picPpt).BeginInit();
        ((System.ComponentModel.ISupportInitialize)picImg).BeginInit();
        statusBar.SuspendLayout();
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
        contextMenu.Size = new Size(157, 76);
        // 
        // menuOpen
        // 
        menuOpen.Name = "menuOpen";
        menuOpen.Size = new Size(156, 22);
        menuOpen.Text = "Открыть";
        menuOpen.Click += menuOpen_Click;
        // 
        // menuOpenFolder
        // 
        menuOpenFolder.Name = "menuOpenFolder";
        menuOpenFolder.Size = new Size(156, 22);
        menuOpenFolder.Text = "Открыть папку";
        menuOpenFolder.Click += menuOpenFolder_Click;
        // 
        // menuSeparator
        // 
        menuSeparator.Name = "menuSeparator";
        menuSeparator.Size = new Size(153, 6);
        // 
        // menuProperties
        // 
        menuProperties.Name = "menuProperties";
        menuProperties.Size = new Size(156, 22);
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
        cmbDrive.Size = new Size(95, 23);
        cmbDrive.TabIndex = 1;
        //
        // btnRefreshDrives
        //
        btnRefreshDrives.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnRefreshDrives.Location = new Point(903, 418);
        btnRefreshDrives.Name = "btnRefreshDrives";
        btnRefreshDrives.Size = new Size(26, 23);
        btnRefreshDrives.TabIndex = 8;
        btnRefreshDrives.Text = "↻";
        btnRefreshDrives.UseVisualStyleBackColor = true;
        btnRefreshDrives.Click += btnRefreshDrives_Click;
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
        txtSearch.TextChanged += txtSearch_TextChanged;
        // 
        // grpFileTypes
        // 
        grpFileTypes.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        grpFileTypes.Controls.Add(picTxt);
        grpFileTypes.Controls.Add(picWord);
        grpFileTypes.Controls.Add(picExcel);
        grpFileTypes.Controls.Add(picPdf);
        grpFileTypes.Controls.Add(picMp3);
        grpFileTypes.Controls.Add(picPpt);
        grpFileTypes.Controls.Add(picImg);
        grpFileTypes.Controls.Add(chkTxt);
        grpFileTypes.Controls.Add(chkWord);
        grpFileTypes.Controls.Add(chkExcel);
        grpFileTypes.Controls.Add(chkPdf);
        grpFileTypes.Controls.Add(chkMp3);
        grpFileTypes.Controls.Add(chkPpt);
        grpFileTypes.Controls.Add(chkImg);
        grpFileTypes.Controls.Add(lblLicenseNotice);
        grpFileTypes.Location = new Point(12, 484);
        grpFileTypes.Name = "grpFileTypes";
        grpFileTypes.Size = new Size(318, 294);
        grpFileTypes.TabIndex = 3;
        grpFileTypes.TabStop = false;
        grpFileTypes.Text = "Типы файлов";
        // 
        // picTxt
        // 
        picTxt.Location = new Point(8, 16);
        picTxt.Name = "picTxt";
        picTxt.Size = new Size(32, 32);
        picTxt.SizeMode = PictureBoxSizeMode.Zoom;
        picTxt.TabIndex = 0;
        picTxt.TabStop = false;
        // 
        // picWord
        // 
        picWord.Location = new Point(8, 52);
        picWord.Name = "picWord";
        picWord.Size = new Size(32, 32);
        picWord.SizeMode = PictureBoxSizeMode.Zoom;
        picWord.TabIndex = 1;
        picWord.TabStop = false;
        // 
        // picExcel
        // 
        picExcel.Location = new Point(8, 88);
        picExcel.Name = "picExcel";
        picExcel.Size = new Size(32, 32);
        picExcel.SizeMode = PictureBoxSizeMode.Zoom;
        picExcel.TabIndex = 2;
        picExcel.TabStop = false;
        // 
        // picPdf
        // 
        picPdf.Location = new Point(8, 124);
        picPdf.Name = "picPdf";
        picPdf.Size = new Size(32, 32);
        picPdf.SizeMode = PictureBoxSizeMode.Zoom;
        picPdf.TabIndex = 3;
        picPdf.TabStop = false;
        // 
        // picMp3
        // 
        picMp3.Location = new Point(8, 160);
        picMp3.Name = "picMp3";
        picMp3.Size = new Size(32, 32);
        picMp3.SizeMode = PictureBoxSizeMode.Zoom;
        picMp3.TabIndex = 4;
        picMp3.TabStop = false;
        // 
        // picPpt
        // 
        picPpt.Location = new Point(8, 196);
        picPpt.Name = "picPpt";
        picPpt.Size = new Size(32, 32);
        picPpt.SizeMode = PictureBoxSizeMode.Zoom;
        picPpt.TabIndex = 5;
        picPpt.TabStop = false;
        // 
        // picImg
        // 
        picImg.Location = new Point(8, 232);
        picImg.Name = "picImg";
        picImg.Size = new Size(32, 32);
        picImg.SizeMode = PictureBoxSizeMode.Zoom;
        picImg.TabIndex = 6;
        picImg.TabStop = false;
        // 
        // chkTxt
        // 
        chkTxt.AutoSize = true;
        chkTxt.Location = new Point(44, 23);
        chkTxt.Name = "chkTxt";
        chkTxt.Size = new Size(157, 19);
        chkTxt.TabIndex = 0;
        chkTxt.Text = "Текстовые файлы (*.txt)";
        // 
        // chkWord
        // 
        chkWord.AutoSize = true;
        chkWord.Location = new Point(44, 59);
        chkWord.Name = "chkWord";
        chkWord.Size = new Size(253, 19);
        chkWord.TabIndex = 1;
        chkWord.Text = "Документы Microsoft Word (*.doc, *.docx)";
        // 
        // chkExcel
        // 
        chkExcel.AutoSize = true;
        chkExcel.Location = new Point(44, 95);
        chkExcel.Name = "chkExcel";
        chkExcel.Size = new Size(236, 19);
        chkExcel.TabIndex = 2;
        chkExcel.Text = "Документы Microsoft Excel (*.xls, *.xlsx)";
        // 
        // chkPdf
        // 
        chkPdf.AutoSize = true;
        chkPdf.Location = new Point(44, 131);
        chkPdf.Name = "chkPdf";
        chkPdf.Size = new Size(150, 19);
        chkPdf.TabIndex = 3;
        chkPdf.Text = "Документы PDF (*.pdf)";
        // 
        // chkMp3
        // 
        chkMp3.AutoSize = true;
        chkMp3.Location = new Point(44, 167);
        chkMp3.Name = "chkMp3";
        chkMp3.Size = new Size(139, 19);
        chkMp3.TabIndex = 4;
        chkMp3.Text = "Музыка mp3 (*.mp3)";
        // 
        // chkPpt
        // 
        chkPpt.AutoSize = true;
        chkPpt.Location = new Point(44, 203);
        chkPpt.Name = "chkPpt";
        chkPpt.Size = new Size(236, 19);
        chkPpt.TabIndex = 5;
        chkPpt.Text = "Презентации PowerPoint (*.ppt, *.pptx)";
        // 
        // chkImg
        // 
        chkImg.AutoSize = true;
        chkImg.Location = new Point(44, 239);
        chkImg.Name = "chkImg";
        chkImg.Size = new Size(240, 19);
        chkImg.TabIndex = 6;
        chkImg.Text = "Изображения (*.jpg, *.png, *.gif, *.bmp)";
        // 
        // lblLicenseNotice
        // 
        lblLicenseNotice.ForeColor = SystemColors.GrayText;
        lblLicenseNotice.Location = new Point(8, 268);
        lblLicenseNotice.Name = "lblLicenseNotice";
        lblLicenseNotice.Size = new Size(300, 18);
        lblLicenseNotice.TabIndex = 7;
        lblLicenseNotice.Text = "PDF, MP3, презентации и картинки — только Pro";
        lblLicenseNotice.Visible = false;
        // 
        // btnSearch
        // 
        btnSearch.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        btnSearch.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        btnSearch.Location = new Point(348, 582);
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
        btnSave.Location = new Point(348, 644);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(140, 28);
        btnSave.TabIndex = 5;
        btnSave.Text = "Сохранить результаты";
        btnSave.Click += btnSave_Click;
        // 
        // btnHelp
        // 
        btnHelp.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
        btnHelp.Location = new Point(885, 750);
        btnHelp.Name = "btnHelp";
        btnHelp.Size = new Size(44, 28);
        btnHelp.TabIndex = 6;
        btnHelp.Text = "?";
        btnHelp.Click += btnHelp_Click;
        // 
        // statusBar
        // 
        statusBar.Items.AddRange(new ToolStripItem[] { statusLabel });
        statusBar.Location = new Point(0, 788);
        statusBar.Name = "statusBar";
        statusBar.Size = new Size(934, 22);
        statusBar.SizingGrip = false;
        statusBar.TabIndex = 9;
        // 
        // statusLabel
        // 
        statusLabel.Name = "statusLabel";
        statusLabel.Size = new Size(919, 17);
        statusLabel.Spring = true;
        statusLabel.TextAlign = ContentAlignment.MiddleLeft;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(934, 810);
        Controls.Add(listResults);
        Controls.Add(lblFound);
        Controls.Add(lblDrive);
        Controls.Add(cmbDrive);
        Controls.Add(btnRefreshDrives);
        Controls.Add(lblSearch);
        Controls.Add(txtSearch);
        Controls.Add(grpFileTypes);
        Controls.Add(btnSearch);
        Controls.Add(btnSave);
        Controls.Add(btnHelp);
        Controls.Add(statusBar);
        MaximizeBox = false;
        MinimumSize = new Size(700, 672);
        Name = "MainForm";
        Text = "FileFinder";
        contextMenu.ResumeLayout(false);
        grpFileTypes.ResumeLayout(false);
        grpFileTypes.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)picTxt).EndInit();
        ((System.ComponentModel.ISupportInitialize)picWord).EndInit();
        ((System.ComponentModel.ISupportInitialize)picExcel).EndInit();
        ((System.ComponentModel.ISupportInitialize)picPdf).EndInit();
        ((System.ComponentModel.ISupportInitialize)picMp3).EndInit();
        ((System.ComponentModel.ISupportInitialize)picPpt).EndInit();
        ((System.ComponentModel.ISupportInitialize)picImg).EndInit();
        statusBar.ResumeLayout(false);
        statusBar.PerformLayout();
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
    private Button btnRefreshDrives;
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
    private StatusStrip statusBar;
    private ToolStripStatusLabel statusLabel;
    private PictureBox picTxt;
    private PictureBox picWord;
    private PictureBox picExcel;
    private PictureBox picPdf;
    private PictureBox picMp3;
    private PictureBox picPpt;
    private PictureBox picImg;
    private CheckBox chkPpt;
    private CheckBox chkImg;
    private Label lblLicenseNotice;
}
