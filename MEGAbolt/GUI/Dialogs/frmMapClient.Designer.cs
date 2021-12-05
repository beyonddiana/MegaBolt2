namespace MEGAbolt
{
    partial class frmMapClient
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMapClient));
            this.btnClose = new System.Windows.Forms.Button();
            this.TabCont = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnClearMarker = new System.Windows.Forms.Button();
            this.chkRange = new System.Windows.Forms.CheckBox();
            this.chkResident = new System.Windows.Forms.CheckBox();
            this.chkForSale = new System.Windows.Forms.CheckBox();
            this.lblSlurl = new System.Windows.Forms.TextBox();
            this.lblDownloading = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmdTP = new System.Windows.Forms.Button();
            this.nuZ = new System.Windows.Forms.NumericUpDown();
            this.nuY = new System.Windows.Forms.NumericUpDown();
            this.nuX = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSimData = new System.Windows.Forms.Label();
            this.world = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTeleport = new System.Windows.Forms.Button();
            this.pnlTeleporting = new System.Windows.Forms.Panel();
            this.proTeleporting = new System.Windows.Forms.ProgressBar();
            this.lblTeleportStatus = new System.Windows.Forms.Label();
            this.pnlTeleportOptions = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.nudX1 = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nudY1 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.nudZ1 = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtSearchFor = new System.Windows.Forms.TextBox();
            this.lbxRegionSearch = new System.Windows.Forms.ListBox();
            this.pictureMap = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TabCont.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.world)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.pnlTeleporting.SuspendLayout();
            this.pnlTeleportOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.AccessibleName = "Close this window button";
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.DimGray;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(199, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // TabCont
            // 
            this.TabCont.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabCont.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.TabCont.Controls.Add(this.tabPage1);
            this.TabCont.Controls.Add(this.tabPage2);
            this.TabCont.Location = new System.Drawing.Point(2, 5);
            this.TabCont.Name = "TabCont";
            this.TabCont.SelectedIndex = 0;
            this.TabCont.Size = new System.Drawing.Size(276, 434);
            this.TabCont.TabIndex = 2;
            this.TabCont.SelectedIndexChanged += new System.EventHandler(this.TabCont_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.btnBrowser);
            this.tabPage1.Controls.Add(this.btnClearMarker);
            this.tabPage1.Controls.Add(this.chkRange);
            this.tabPage1.Controls.Add(this.chkResident);
            this.tabPage1.Controls.Add(this.chkForSale);
            this.tabPage1.Controls.Add(this.lblSlurl);
            this.tabPage1.Controls.Add(this.lblDownloading);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmdTP);
            this.tabPage1.Controls.Add(this.nuZ);
            this.tabPage1.Controls.Add(this.nuY);
            this.tabPage1.Controls.Add(this.nuX);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblSimData);
            this.tabPage1.Controls.Add(this.world);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(268, 405);
            this.tabPage1.TabIndex = 0;
            // 
            // btnBrowser
            // 
            this.btnBrowser.AccessibleName = "View in browser";
            this.btnBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowser.BackColor = System.Drawing.Color.DimGray;
            this.btnBrowser.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrowser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowser.ForeColor = System.Drawing.Color.White;
            this.btnBrowser.Location = new System.Drawing.Point(162, 341);
            this.btnBrowser.Name = "button3";
            this.btnBrowser.Size = new System.Drawing.Size(100, 23);
            this.btnBrowser.TabIndex = 13;
            this.btnBrowser.Text = "View in browser";
            this.btnBrowser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBrowser.UseVisualStyleBackColor = false;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnClearMarker
            // 
            this.btnClearMarker.AccessibleName = "Clear marker from map option";
            this.btnClearMarker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearMarker.BackColor = System.Drawing.Color.DimGray;
            this.btnClearMarker.Enabled = false;
            this.btnClearMarker.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClearMarker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnClearMarker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearMarker.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearMarker.ForeColor = System.Drawing.Color.White;
            this.btnClearMarker.Location = new System.Drawing.Point(214, 261);
            this.btnClearMarker.Name = "button1";
            this.btnClearMarker.Size = new System.Drawing.Size(48, 23);
            this.btnClearMarker.TabIndex = 2;
            this.btnClearMarker.Text = "cl&ear";
            this.btnClearMarker.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnClearMarker.UseVisualStyleBackColor = false;
            this.btnClearMarker.Click += new System.EventHandler(this.btnClearMarker_Click);
            // 
            // chkRange
            // 
            this.chkRange.AccessibleName = "Range";
            this.chkRange.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkRange.AutoSize = true;
            this.chkRange.Checked = true;
            this.chkRange.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRange.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkRange.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkRange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkRange.Location = new System.Drawing.Point(162, 264);
            this.chkRange.Name = "checkBox1";
            this.chkRange.Size = new System.Drawing.Size(54, 17);
            this.chkRange.TabIndex = 12;
            this.chkRange.Text = "Range";
            this.chkRange.UseVisualStyleBackColor = true;
            // 
            // chkResident
            // 
            this.chkResident.AccessibleName = "Display residents option";
            this.chkResident.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkResident.AutoSize = true;
            this.chkResident.Checked = true;
            this.chkResident.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkResident.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkResident.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkResident.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkResident.Location = new System.Drawing.Point(95, 264);
            this.chkResident.Name = "chkResident";
            this.chkResident.Size = new System.Drawing.Size(65, 17);
            this.chkResident.TabIndex = 1;
            this.chkResident.Text = "Resident";
            this.chkResident.UseVisualStyleBackColor = true;
            // 
            // chkForSale
            // 
            this.chkForSale.AccessibleName = "Land for sale option";
            this.chkForSale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.chkForSale.AutoSize = true;
            this.chkForSale.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkForSale.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkForSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkForSale.Location = new System.Drawing.Point(6, 264);
            this.chkForSale.Name = "chkForSale";
            this.chkForSale.Size = new System.Drawing.Size(86, 17);
            this.chkForSale.TabIndex = 0;
            this.chkForSale.Text = "Land for Sale";
            this.chkForSale.UseVisualStyleBackColor = true;
            this.chkForSale.CheckedChanged += new System.EventHandler(this.chkForSale_CheckedChanged);
            // 
            // lblSlurl
            // 
            this.lblSlurl.AccessibleName = "SLurl of selected position textbox";
            this.lblSlurl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSlurl.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSlurl.ForeColor = System.Drawing.Color.Gray;
            this.lblSlurl.Location = new System.Drawing.Point(6, 316);
            this.lblSlurl.Name = "lblSlurl";
            this.lblSlurl.ReadOnly = true;
            this.lblSlurl.Size = new System.Drawing.Size(256, 21);
            this.lblSlurl.TabIndex = 3;
            // 
            // lblDownloading
            // 
            this.lblDownloading.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDownloading.ForeColor = System.Drawing.Color.Red;
            this.lblDownloading.Location = new System.Drawing.Point(6, 6);
            this.lblDownloading.Name = "lblDownloading";
            this.lblDownloading.Size = new System.Drawing.Size(111, 17);
            this.lblDownloading.TabIndex = 11;
            this.lblDownloading.Text = "MAP downloading...";
            this.lblDownloading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(130, 381);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Z";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 381);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            // 
            // cmdTP
            // 
            this.cmdTP.AccessibleDescription = "Teleports the avatar to the selected position";
            this.cmdTP.AccessibleName = "Teleport button";
            this.cmdTP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cmdTP.BackColor = System.Drawing.Color.DimGray;
            this.cmdTP.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.cmdTP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.cmdTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmdTP.ForeColor = System.Drawing.Color.White;
            this.cmdTP.Location = new System.Drawing.Point(201, 376);
            this.cmdTP.Name = "cmdTP";
            this.cmdTP.Size = new System.Drawing.Size(61, 23);
            this.cmdTP.TabIndex = 7;
            this.cmdTP.Text = "&Teleport";
            this.cmdTP.UseVisualStyleBackColor = false;
            this.cmdTP.Click += new System.EventHandler(this.button1_Click);
            // 
            // nuZ
            // 
            this.nuZ.AccessibleName = "Z coordinate setting";
            this.nuZ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nuZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nuZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nuZ.Location = new System.Drawing.Point(147, 377);
            this.nuZ.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuZ.Name = "nuZ";
            this.nuZ.Size = new System.Drawing.Size(51, 21);
            this.nuZ.TabIndex = 6;
            this.nuZ.ValueChanged += new System.EventHandler(this.nuZ_ValueChanged);
            // 
            // nuY
            // 
            this.nuY.AccessibleName = "Y coordinate setting";
            this.nuY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nuY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nuY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nuY.Location = new System.Drawing.Point(87, 377);
            this.nuY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nuY.Name = "nuY";
            this.nuY.Size = new System.Drawing.Size(39, 21);
            this.nuY.TabIndex = 5;
            this.nuY.ValueChanged += new System.EventHandler(this.nuY_ValueChanged);
            this.nuY.MouseUp += new System.Windows.Forms.MouseEventHandler(this.nuY_MouseUp);
            // 
            // nuX
            // 
            this.nuX.AccessibleName = "X coordinate setting";
            this.nuX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nuX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nuX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nuX.Location = new System.Drawing.Point(27, 377);
            this.nuX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nuX.Name = "nuX";
            this.nuX.Size = new System.Drawing.Size(39, 21);
            this.nuX.TabIndex = 4;
            this.nuX.ValueChanged += new System.EventHandler(this.nuX_ValueChanged);
            this.nuX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.nuX_Scroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selected position:";
            // 
            // lblSimData
            // 
            this.lblSimData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblSimData.AutoSize = true;
            this.lblSimData.Location = new System.Drawing.Point(6, 292);
            this.lblSimData.Name = "lblSimData";
            this.lblSimData.Size = new System.Drawing.Size(0, 13);
            this.lblSimData.TabIndex = 1;
            // 
            // world
            // 
            this.world.AccessibleName = "Map image";
            this.world.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.world.Location = new System.Drawing.Point(6, 6);
            this.world.Name = "world";
            this.world.Size = new System.Drawing.Size(256, 256);
            this.world.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.world.TabIndex = 0;
            this.world.TabStop = false;
            this.world.Click += new System.EventHandler(this.world_Click);
            this.world.MouseMove += new System.Windows.Forms.MouseEventHandler(this.world_MouseMove);
            this.world.MouseUp += new System.Windows.Forms.MouseEventHandler(this.world_MouseUp);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.btnTeleport);
            this.tabPage2.Controls.Add(this.pnlTeleporting);
            this.tabPage2.Controls.Add(this.pnlTeleportOptions);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.btnFind);
            this.tabPage2.Controls.Add(this.txtSearchFor);
            this.tabPage2.Controls.Add(this.lbxRegionSearch);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(268, 405);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Search";
            // 
            // button4
            // 
            this.button4.AccessibleName = "Clear marker from map option";
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(311, 268);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 23);
            this.button4.TabIndex = 20;
            this.button4.Text = "View in browser";
            this.button4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.AccessibleName = "Clear marker from map option";
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(495, 268);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(72, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "cl&ear";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnTeleport
            // 
            this.btnTeleport.AccessibleName = "Teleport button";
            this.btnTeleport.BackColor = System.Drawing.Color.DimGray;
            this.btnTeleport.Enabled = false;
            this.btnTeleport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnTeleport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeleport.ForeColor = System.Drawing.Color.White;
            this.btnTeleport.Location = new System.Drawing.Point(495, 374);
            this.btnTeleport.Name = "btnTeleport";
            this.btnTeleport.Size = new System.Drawing.Size(72, 23);
            this.btnTeleport.TabIndex = 18;
            this.btnTeleport.Text = "&Teleport";
            this.btnTeleport.UseVisualStyleBackColor = false;
            this.btnTeleport.Click += new System.EventHandler(this.btnTeleport_Click);
            // 
            // pnlTeleporting
            // 
            this.pnlTeleporting.Controls.Add(this.proTeleporting);
            this.pnlTeleporting.Controls.Add(this.lblTeleportStatus);
            this.pnlTeleporting.Location = new System.Drawing.Point(311, 225);
            this.pnlTeleporting.Name = "pnlTeleporting";
            this.pnlTeleporting.Size = new System.Drawing.Size(256, 41);
            this.pnlTeleporting.TabIndex = 17;
            this.pnlTeleporting.Visible = false;
            // 
            // proTeleporting
            // 
            this.proTeleporting.AccessibleName = "Teleport progress bar";
            this.proTeleporting.Location = new System.Drawing.Point(3, 19);
            this.proTeleporting.Name = "proTeleporting";
            this.proTeleporting.Size = new System.Drawing.Size(250, 16);
            this.proTeleporting.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.proTeleporting.TabIndex = 1;
            // 
            // lblTeleportStatus
            // 
            this.lblTeleportStatus.AutoSize = true;
            this.lblTeleportStatus.Location = new System.Drawing.Point(3, 3);
            this.lblTeleportStatus.Name = "lblTeleportStatus";
            this.lblTeleportStatus.Size = new System.Drawing.Size(73, 13);
            this.lblTeleportStatus.TabIndex = 0;
            this.lblTeleportStatus.Text = "Teleporting...";
            // 
            // pnlTeleportOptions
            // 
            this.pnlTeleportOptions.Controls.Add(this.label8);
            this.pnlTeleportOptions.Controls.Add(this.txtRegion);
            this.pnlTeleportOptions.Controls.Add(this.nudX1);
            this.pnlTeleportOptions.Controls.Add(this.label9);
            this.pnlTeleportOptions.Controls.Add(this.nudY1);
            this.pnlTeleportOptions.Controls.Add(this.label10);
            this.pnlTeleportOptions.Controls.Add(this.nudZ1);
            this.pnlTeleportOptions.Controls.Add(this.label11);
            this.pnlTeleportOptions.Location = new System.Drawing.Point(311, 305);
            this.pnlTeleportOptions.Name = "pnlTeleportOptions";
            this.pnlTeleportOptions.Size = new System.Drawing.Size(172, 98);
            this.pnlTeleportOptions.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Region";
            // 
            // txtRegion
            // 
            this.txtRegion.AccessibleName = "Found or selected SIM name textbox";
            this.txtRegion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRegion.Location = new System.Drawing.Point(6, 21);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(163, 21);
            this.txtRegion.TabIndex = 0;
            this.txtRegion.TextChanged += new System.EventHandler(this.txtRegion_TextChanged);
            // 
            // nudX1
            // 
            this.nudX1.AccessibleName = "X coordinate setting";
            this.nudX1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudX1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudX1.Location = new System.Drawing.Point(8, 70);
            this.nudX1.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudX1.Name = "nudX1";
            this.nudX1.Size = new System.Drawing.Size(48, 21);
            this.nudX1.TabIndex = 1;
            this.nudX1.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "X";
            // 
            // nudY1
            // 
            this.nudY1.AccessibleName = "Y coordinate setting";
            this.nudY1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudY1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudY1.Location = new System.Drawing.Point(62, 70);
            this.nudY1.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudY1.Name = "nudY1";
            this.nudY1.Size = new System.Drawing.Size(48, 21);
            this.nudY1.TabIndex = 2;
            this.nudY1.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(113, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Z";
            // 
            // nudZ1
            // 
            this.nudZ1.AccessibleName = "Z coordinate setting";
            this.nudZ1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudZ1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudZ1.Location = new System.Drawing.Point(116, 70);
            this.nudZ1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudZ1.Name = "nudZ1";
            this.nudZ1.Size = new System.Drawing.Size(48, 21);
            this.nudZ1.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Y";
            // 
            // pictureBox2
            // 
            this.pictureBox2.AccessibleName = "Map image";
            this.pictureBox2.Location = new System.Drawing.Point(311, 10);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(256, 256);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // btnFind
            // 
            this.btnFind.AccessibleName = "Search button";
            this.btnFind.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFind.Enabled = false;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(246, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(59, 23);
            this.btnFind.TabIndex = 5;
            this.btnFind.Text = "&Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtSearchFor
            // 
            this.txtSearchFor.AccessibleDescription = "Enter the name of the SIM you are searching for";
            this.txtSearchFor.AccessibleName = "Search textbox";
            this.txtSearchFor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchFor.Location = new System.Drawing.Point(5, 12);
            this.txtSearchFor.Name = "txtSearchFor";
            this.txtSearchFor.Size = new System.Drawing.Size(235, 21);
            this.txtSearchFor.TabIndex = 4;
            this.txtSearchFor.TextChanged += new System.EventHandler(this.txtSearchFor_TextChanged);
            this.txtSearchFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchFor_KeyDown);
            this.txtSearchFor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchFor_KeyUp);
            // 
            // lbxRegionSearch
            // 
            this.lbxRegionSearch.AccessibleDescription = "Select the SIM you need";
            this.lbxRegionSearch.AccessibleName = "Found SIMs listbox";
            this.lbxRegionSearch.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxRegionSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxRegionSearch.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbxRegionSearch.FormattingEnabled = true;
            this.lbxRegionSearch.IntegralHeight = false;
            this.lbxRegionSearch.ItemHeight = 74;
            this.lbxRegionSearch.Location = new System.Drawing.Point(6, 41);
            this.lbxRegionSearch.Name = "lbxRegionSearch";
            this.lbxRegionSearch.Size = new System.Drawing.Size(299, 361);
            this.lbxRegionSearch.TabIndex = 3;
            this.lbxRegionSearch.Click += new System.EventHandler(this.lbxRegionSearch_Click);
            this.lbxRegionSearch.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxRegionSearch_DrawItem);
            this.lbxRegionSearch.DoubleClick += new System.EventHandler(this.lbxRegionSearch_DoubleClick);
            // 
            // pictureMap
            // 
            this.pictureMap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureMap.Image = global::MEGAbolt.Properties.Resources.Help_and_Support_16;
            this.pictureMap.Location = new System.Drawing.Point(6, 447);
            this.pictureMap.Name = "pictureMap";
            this.pictureMap.Size = new System.Drawing.Size(15, 15);
            this.pictureMap.TabIndex = 6;
            this.pictureMap.TabStop = false;
            this.pictureMap.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureMap.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureMap.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // toolTip1
            // 
            this.toolTip1.AutomaticDelay = 250;
            this.toolTip1.IsBalloon = true;
            // 
            // frmMapClient
            // 
            this.AccessibleDescription = "Displays the map of the current SIM";
            this.AccessibleName = "Map window";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(284, 469);
            this.Controls.Add(this.pictureMap);
            this.Controls.Add(this.TabCont);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmMapClient";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MEGAbolt Map";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMapClient_FormClosing);
            this.Load += new System.EventHandler(this.frmMapClient_Load);
            this.SizeChanged += new System.EventHandler(this.frmMapClient_SizeChanged);
            this.Enter += new System.EventHandler(this.frmMapClient_Enter);
            this.TabCont.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.world)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.pnlTeleporting.ResumeLayout(false);
            this.pnlTeleporting.PerformLayout();
            this.pnlTeleportOptions.ResumeLayout(false);
            this.pnlTeleportOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TabControl TabCont;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.PictureBox world;
        private System.Windows.Forms.Label lblSimData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nuX;
        private System.Windows.Forms.NumericUpDown nuY;
        private System.Windows.Forms.NumericUpDown nuZ;
        private System.Windows.Forms.Button cmdTP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDownloading;
        private System.Windows.Forms.TextBox lblSlurl;
        private System.Windows.Forms.PictureBox pictureMap;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnClearMarker;
        private System.Windows.Forms.CheckBox chkForSale;
        private System.Windows.Forms.CheckBox chkResident;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbxRegionSearch;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtSearchFor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel pnlTeleportOptions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.NumericUpDown nudX1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudY1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudZ1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel pnlTeleporting;
        private System.Windows.Forms.ProgressBar proTeleporting;
        private System.Windows.Forms.Label lblTeleportStatus;
        private System.Windows.Forms.Button btnTeleport;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox chkRange;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.Button button4;
    }
}

