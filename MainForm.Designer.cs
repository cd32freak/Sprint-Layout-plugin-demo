namespace SprintLayoutPluginDemo
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rtbDebug = new System.Windows.Forms.RichTextBox();
            this.txtLanguage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProcessID = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rtbFileContent = new System.Windows.Forms.RichTextBox();
            this.grpGrid = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGridSettingmm = new System.Windows.Forms.TextBox();
            this.lblOriginYmm = new System.Windows.Forms.Label();
            this.txtOriginYmm = new System.Windows.Forms.TextBox();
            this.lblOriginXmm = new System.Windows.Forms.Label();
            this.txtOriginXmm = new System.Windows.Forms.TextBox();
            this.lblHeightmm = new System.Windows.Forms.Label();
            this.txtHeightmm = new System.Windows.Forms.TextBox();
            this.lblWidthmm = new System.Windows.Forms.Label();
            this.txtWidthmm = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpContent = new System.Windows.Forms.GroupBox();
            this.grpDebug = new System.Windows.Forms.GroupBox();
            this.cmbExitCodes = new System.Windows.Forms.ComboBox();
            this.grpExitCode = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.grpBoard = new System.Windows.Forms.GroupBox();
            this.grpOrigin = new System.Windows.Forms.GroupBox();
            this.grpSearchReplace = new System.Windows.Forms.GroupBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtReplace = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.grpGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpContent.SuspendLayout();
            this.grpDebug.SuspendLayout();
            this.grpExitCode.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpBoard.SuspendLayout();
            this.grpOrigin.SuspendLayout();
            this.grpSearchReplace.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbDebug
            // 
            this.rtbDebug.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rtbDebug.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbDebug.Location = new System.Drawing.Point(9, 19);
            this.rtbDebug.Name = "rtbDebug";
            this.rtbDebug.Size = new System.Drawing.Size(357, 170);
            this.rtbDebug.TabIndex = 0;
            this.rtbDebug.Text = "";
            // 
            // txtLanguage
            // 
            this.txtLanguage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanguage.Location = new System.Drawing.Point(603, 130);
            this.txtLanguage.Name = "txtLanguage";
            this.txtLanguage.Size = new System.Drawing.Size(26, 20);
            this.txtLanguage.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Language:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Width:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Height:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Y:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "X:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(536, 167);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Process ID:";
            // 
            // txtProcessID
            // 
            this.txtProcessID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProcessID.Location = new System.Drawing.Point(603, 163);
            this.txtProcessID.Name = "txtProcessID";
            this.txtProcessID.Size = new System.Drawing.Size(50, 20);
            this.txtProcessID.TabIndex = 17;
            this.txtProcessID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPath
            // 
            this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(70, 41);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(583, 20);
            this.txtPath.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Input file:";
            // 
            // rtbFileContent
            // 
            this.rtbFileContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbFileContent.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFileContent.Location = new System.Drawing.Point(3, 16);
            this.rtbFileContent.Name = "rtbFileContent";
            this.rtbFileContent.Size = new System.Drawing.Size(904, 307);
            this.rtbFileContent.TabIndex = 0;
            this.rtbFileContent.Text = "";
            // 
            // grpGrid
            // 
            this.grpGrid.Controls.Add(this.pictureBox1);
            this.grpGrid.Controls.Add(this.label11);
            this.grpGrid.Controls.Add(this.txtGridSettingmm);
            this.grpGrid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGrid.Location = new System.Drawing.Point(535, 72);
            this.grpGrid.Name = "grpGrid";
            this.grpGrid.Size = new System.Drawing.Size(121, 57);
            this.grpGrid.TabIndex = 24;
            this.grpGrid.TabStop = false;
            this.grpGrid.Text = "Grid";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 21);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(93, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(23, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "mm";
            // 
            // txtGridSettingmm
            // 
            this.txtGridSettingmm.BackColor = System.Drawing.Color.Black;
            this.txtGridSettingmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGridSettingmm.ForeColor = System.Drawing.Color.Yellow;
            this.txtGridSettingmm.Location = new System.Drawing.Point(40, 19);
            this.txtGridSettingmm.Name = "txtGridSettingmm";
            this.txtGridSettingmm.Size = new System.Drawing.Size(50, 20);
            this.txtGridSettingmm.TabIndex = 30;
            this.txtGridSettingmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOriginYmm
            // 
            this.lblOriginYmm.AutoSize = true;
            this.lblOriginYmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginYmm.Location = new System.Drawing.Point(106, 48);
            this.lblOriginYmm.Name = "lblOriginYmm";
            this.lblOriginYmm.Size = new System.Drawing.Size(23, 13);
            this.lblOriginYmm.TabIndex = 28;
            this.lblOriginYmm.Text = "mm";
            // 
            // txtOriginYmm
            // 
            this.txtOriginYmm.BackColor = System.Drawing.Color.Black;
            this.txtOriginYmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginYmm.ForeColor = System.Drawing.Color.Yellow;
            this.txtOriginYmm.Location = new System.Drawing.Point(53, 44);
            this.txtOriginYmm.Name = "txtOriginYmm";
            this.txtOriginYmm.Size = new System.Drawing.Size(50, 20);
            this.txtOriginYmm.TabIndex = 27;
            this.txtOriginYmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblOriginXmm
            // 
            this.lblOriginXmm.AutoSize = true;
            this.lblOriginXmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginXmm.Location = new System.Drawing.Point(106, 22);
            this.lblOriginXmm.Name = "lblOriginXmm";
            this.lblOriginXmm.Size = new System.Drawing.Size(23, 13);
            this.lblOriginXmm.TabIndex = 26;
            this.lblOriginXmm.Text = "mm";
            // 
            // txtOriginXmm
            // 
            this.txtOriginXmm.BackColor = System.Drawing.Color.Black;
            this.txtOriginXmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOriginXmm.ForeColor = System.Drawing.Color.Yellow;
            this.txtOriginXmm.Location = new System.Drawing.Point(53, 19);
            this.txtOriginXmm.Name = "txtOriginXmm";
            this.txtOriginXmm.Size = new System.Drawing.Size(50, 20);
            this.txtOriginXmm.TabIndex = 25;
            this.txtOriginXmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblHeightmm
            // 
            this.lblHeightmm.AutoSize = true;
            this.lblHeightmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightmm.Location = new System.Drawing.Point(106, 59);
            this.lblHeightmm.Name = "lblHeightmm";
            this.lblHeightmm.Size = new System.Drawing.Size(23, 13);
            this.lblHeightmm.TabIndex = 24;
            this.lblHeightmm.Text = "mm";
            // 
            // txtHeightmm
            // 
            this.txtHeightmm.BackColor = System.Drawing.Color.Black;
            this.txtHeightmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHeightmm.ForeColor = System.Drawing.Color.Yellow;
            this.txtHeightmm.Location = new System.Drawing.Point(53, 55);
            this.txtHeightmm.Name = "txtHeightmm";
            this.txtHeightmm.Size = new System.Drawing.Size(50, 20);
            this.txtHeightmm.TabIndex = 23;
            this.txtHeightmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblWidthmm
            // 
            this.lblWidthmm.AutoSize = true;
            this.lblWidthmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidthmm.Location = new System.Drawing.Point(106, 33);
            this.lblWidthmm.Name = "lblWidthmm";
            this.lblWidthmm.Size = new System.Drawing.Size(23, 13);
            this.lblWidthmm.TabIndex = 22;
            this.lblWidthmm.Text = "mm";
            // 
            // txtWidthmm
            // 
            this.txtWidthmm.BackColor = System.Drawing.Color.Black;
            this.txtWidthmm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWidthmm.ForeColor = System.Drawing.Color.Yellow;
            this.txtWidthmm.Location = new System.Drawing.Point(53, 27);
            this.txtWidthmm.Name = "txtWidthmm";
            this.txtWidthmm.Size = new System.Drawing.Size(50, 20);
            this.txtWidthmm.TabIndex = 21;
            this.txtWidthmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(848, 663);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.Location = new System.Drawing.Point(10, 663);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grpContent
            // 
            this.grpContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpContent.Controls.Add(this.rtbFileContent);
            this.grpContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpContent.Location = new System.Drawing.Point(10, 273);
            this.grpContent.Name = "grpContent";
            this.grpContent.Size = new System.Drawing.Size(913, 321);
            this.grpContent.TabIndex = 0;
            this.grpContent.TabStop = false;
            this.grpContent.Text = "Content";
            // 
            // grpDebug
            // 
            this.grpDebug.Controls.Add(this.rtbDebug);
            this.grpDebug.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDebug.Location = new System.Drawing.Point(10, 72);
            this.grpDebug.Name = "grpDebug";
            this.grpDebug.Size = new System.Drawing.Size(372, 195);
            this.grpDebug.TabIndex = 28;
            this.grpDebug.TabStop = false;
            this.grpDebug.Text = "Debug parameters";
            // 
            // cmbExitCodes
            // 
            this.cmbExitCodes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmbExitCodes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbExitCodes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbExitCodes.FormattingEnabled = true;
            this.cmbExitCodes.Items.AddRange(new object[] {
            "0: Abort / no action",
            "1: Replace elements absolutely",
            "2: Add elements absolutely",
            "3: Replace elements relatively",
            "4: Add elements relatively"});
            this.cmbExitCodes.Location = new System.Drawing.Point(9, 19);
            this.cmbExitCodes.Name = "cmbExitCodes";
            this.cmbExitCodes.Size = new System.Drawing.Size(199, 21);
            this.cmbExitCodes.TabIndex = 29;
            // 
            // grpExitCode
            // 
            this.grpExitCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpExitCode.Controls.Add(this.cmbExitCodes);
            this.grpExitCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExitCode.Location = new System.Drawing.Point(10, 602);
            this.grpExitCode.Name = "grpExitCode";
            this.grpExitCode.Size = new System.Drawing.Size(217, 55);
            this.grpExitCode.TabIndex = 30;
            this.grpExitCode.TabStop = false;
            this.grpExitCode.Text = "Exit code";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(931, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Enabled = false;
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 694);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(931, 22);
            this.statusStrip1.TabIndex = 32;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.AutoSize = false;
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(458, 17);
            this.toolStripStatusLabel1.Spring = true;
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.toolStripStatusLabel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(458, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpBoard
            // 
            this.grpBoard.Controls.Add(this.label2);
            this.grpBoard.Controls.Add(this.label3);
            this.grpBoard.Controls.Add(this.txtWidthmm);
            this.grpBoard.Controls.Add(this.lblWidthmm);
            this.grpBoard.Controls.Add(this.txtHeightmm);
            this.grpBoard.Controls.Add(this.lblHeightmm);
            this.grpBoard.Location = new System.Drawing.Point(388, 72);
            this.grpBoard.Name = "grpBoard";
            this.grpBoard.Size = new System.Drawing.Size(141, 89);
            this.grpBoard.TabIndex = 33;
            this.grpBoard.TabStop = false;
            this.grpBoard.Text = "Board";
            // 
            // grpOrigin
            // 
            this.grpOrigin.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.grpOrigin.Controls.Add(this.label6);
            this.grpOrigin.Controls.Add(this.label5);
            this.grpOrigin.Controls.Add(this.txtOriginXmm);
            this.grpOrigin.Controls.Add(this.lblOriginYmm);
            this.grpOrigin.Controls.Add(this.lblOriginXmm);
            this.grpOrigin.Controls.Add(this.txtOriginYmm);
            this.grpOrigin.Location = new System.Drawing.Point(388, 167);
            this.grpOrigin.Name = "grpOrigin";
            this.grpOrigin.Size = new System.Drawing.Size(138, 78);
            this.grpOrigin.TabIndex = 32;
            this.grpOrigin.TabStop = false;
            this.grpOrigin.Text = "Origin";
            // 
            // grpSearchReplace
            // 
            this.grpSearchReplace.Controls.Add(this.btnReplaceAll);
            this.grpSearchReplace.Controls.Add(this.btnReplace);
            this.grpSearchReplace.Controls.Add(this.btnSearch);
            this.grpSearchReplace.Controls.Add(this.txtReplace);
            this.grpSearchReplace.Controls.Add(this.txtSearch);
            this.grpSearchReplace.Location = new System.Drawing.Point(245, 603);
            this.grpSearchReplace.Name = "grpSearchReplace";
            this.grpSearchReplace.Size = new System.Drawing.Size(380, 83);
            this.grpSearchReplace.TabIndex = 34;
            this.grpSearchReplace.TabStop = false;
            this.grpSearchReplace.Text = "Search and replace";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(6, 19);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(196, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // txtReplace
            // 
            this.txtReplace.Location = new System.Drawing.Point(6, 49);
            this.txtReplace.Name = "txtReplace";
            this.txtReplace.Size = new System.Drawing.Size(196, 20);
            this.txtReplace.TabIndex = 1;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(208, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(208, 48);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(75, 23);
            this.btnReplace.TabIndex = 3;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.Location = new System.Drawing.Point(289, 48);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btnReplaceAll.TabIndex = 4;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = true;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 716);
            this.Controls.Add(this.grpSearchReplace);
            this.Controls.Add(this.grpOrigin);
            this.Controls.Add(this.grpBoard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtLanguage);
            this.Controls.Add(this.grpExitCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProcessID);
            this.Controls.Add(this.grpDebug);
            this.Controls.Add(this.grpContent);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpGrid);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label10);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sprint-Layout plugin demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.grpGrid.ResumeLayout(false);
            this.grpGrid.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpContent.ResumeLayout(false);
            this.grpDebug.ResumeLayout(false);
            this.grpExitCode.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpBoard.ResumeLayout(false);
            this.grpBoard.PerformLayout();
            this.grpOrigin.ResumeLayout(false);
            this.grpOrigin.PerformLayout();
            this.grpSearchReplace.ResumeLayout(false);
            this.grpSearchReplace.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbDebug;
        private System.Windows.Forms.TextBox txtLanguage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProcessID;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox rtbFileContent;
        private System.Windows.Forms.GroupBox grpGrid;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpContent;
        private System.Windows.Forms.GroupBox grpDebug;
        private System.Windows.Forms.ComboBox cmbExitCodes;
        private System.Windows.Forms.GroupBox grpExitCode;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TextBox txtWidthmm;
        private System.Windows.Forms.Label lblHeightmm;
        private System.Windows.Forms.TextBox txtHeightmm;
        private System.Windows.Forms.Label lblWidthmm;
        private System.Windows.Forms.Label lblOriginYmm;
        private System.Windows.Forms.TextBox txtOriginYmm;
        private System.Windows.Forms.Label lblOriginXmm;
        private System.Windows.Forms.TextBox txtOriginXmm;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGridSettingmm;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox grpBoard;
        private System.Windows.Forms.GroupBox grpOrigin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpSearchReplace;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtReplace;
        private System.Windows.Forms.Button btnReplaceAll;
    }
}

