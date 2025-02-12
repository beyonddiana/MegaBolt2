namespace MEGAbolt
{
    partial class frmTeleport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTeleport));
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchFor = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRegion = new System.Windows.Forms.TextBox();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nudY = new System.Windows.Forms.NumericUpDown();
            this.nudZ = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTeleport = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbxRegionSearch = new System.Windows.Forms.ListBox();
            this.pnlTeleporting = new System.Windows.Forms.Panel();
            this.proTeleporting = new System.Windows.Forms.ProgressBar();
            this.lblTeleportStatus = new System.Windows.Forms.Label();
            this.pnlTeleportOptions = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.trkIconSize = new System.Windows.Forms.TrackBar();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).BeginInit();
            this.pnlTeleporting.SuspendLayout();
            this.pnlTeleportOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkIconSize)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search for:";
            // 
            // txtSearchFor
            // 
            this.txtSearchFor.AccessibleDescription = "Enter the name of the SIM you are searchign for";
            this.txtSearchFor.AccessibleName = "Search textbox";
            this.txtSearchFor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchFor.Location = new System.Drawing.Point(79, 12);
            this.txtSearchFor.Name = "txtSearchFor";
            this.txtSearchFor.Size = new System.Drawing.Size(219, 21);
            this.txtSearchFor.TabIndex = 0;
            this.txtSearchFor.TextChanged += new System.EventHandler(this.txtSearchFor_TextChanged);
            this.txtSearchFor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchFor_KeyDown);
            this.txtSearchFor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchFor_KeyUp);
            // 
            // btnFind
            // 
            this.btnFind.AccessibleName = "Search button";
            this.btnFind.BackColor = System.Drawing.Color.SeaGreen;
            this.btnFind.Enabled = false;
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(304, 10);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(72, 23);
            this.btnFind.TabIndex = 1;
            this.btnFind.Text = "&Search";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Region";
            // 
            // txtRegion
            // 
            this.txtRegion.AccessibleName = "Found or selected SIM name textbox";
            this.txtRegion.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtRegion.Location = new System.Drawing.Point(6, 25);
            this.txtRegion.Name = "txtRegion";
            this.txtRegion.Size = new System.Drawing.Size(156, 21);
            this.txtRegion.TabIndex = 0;
            this.txtRegion.TextChanged += new System.EventHandler(this.txtRegion_TextChanged);
            // 
            // nudX
            // 
            this.nudX.AccessibleName = "X coordinate setting";
            this.nudX.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudX.Location = new System.Drawing.Point(6, 65);
            this.nudX.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(48, 21);
            this.nudX.TabIndex = 1;
            this.nudX.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "X";
            // 
            // nudY
            // 
            this.nudY.AccessibleName = "Y coordinate setting";
            this.nudY.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudY.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudY.Location = new System.Drawing.Point(60, 65);
            this.nudY.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.nudY.Name = "nudY";
            this.nudY.Size = new System.Drawing.Size(48, 21);
            this.nudY.TabIndex = 2;
            this.nudY.Value = new decimal(new int[] {
            128,
            0,
            0,
            0});
            // 
            // nudZ
            // 
            this.nudZ.AccessibleName = "Z coordinate setting";
            this.nudZ.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudZ.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nudZ.Location = new System.Drawing.Point(114, 65);
            this.nudZ.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudZ.Name = "nudZ";
            this.nudZ.Size = new System.Drawing.Size(48, 21);
            this.nudZ.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(111, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Z";
            // 
            // btnTeleport
            // 
            this.btnTeleport.AccessibleName = "Teleport button";
            this.btnTeleport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTeleport.BackColor = System.Drawing.Color.DimGray;
            this.btnTeleport.Enabled = false;
            this.btnTeleport.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTeleport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnTeleport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeleport.ForeColor = System.Drawing.Color.White;
            this.btnTeleport.Location = new System.Drawing.Point(382, 325);
            this.btnTeleport.Name = "btnTeleport";
            this.btnTeleport.Size = new System.Drawing.Size(172, 23);
            this.btnTeleport.TabIndex = 4;
            this.btnTeleport.Text = "&Teleport";
            this.btnTeleport.UseVisualStyleBackColor = false;
            this.btnTeleport.Click += new System.EventHandler(this.btnTeleport_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleName = "Cancel and close window button";
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(382, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
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
            this.lbxRegionSearch.Location = new System.Drawing.Point(12, 39);
            this.lbxRegionSearch.Name = "lbxRegionSearch";
            this.lbxRegionSearch.Size = new System.Drawing.Size(364, 337);
            this.lbxRegionSearch.TabIndex = 2;
            this.lbxRegionSearch.Click += new System.EventHandler(this.lbxRegionSearch_Click);
            this.lbxRegionSearch.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxRegionSearch_DrawItem);
            this.lbxRegionSearch.DoubleClick += new System.EventHandler(this.lbxRegionSearch_DoubleClick);
            // 
            // pnlTeleporting
            // 
            this.pnlTeleporting.Controls.Add(this.proTeleporting);
            this.pnlTeleporting.Controls.Add(this.lblTeleportStatus);
            this.pnlTeleporting.Location = new System.Drawing.Point(382, 248);
            this.pnlTeleporting.Name = "pnlTeleporting";
            this.pnlTeleporting.Size = new System.Drawing.Size(172, 41);
            this.pnlTeleporting.TabIndex = 16;
            this.pnlTeleporting.Visible = false;
            // 
            // proTeleporting
            // 
            this.proTeleporting.AccessibleName = "Teleport progress bar";
            this.proTeleporting.Location = new System.Drawing.Point(3, 19);
            this.proTeleporting.Name = "proTeleporting";
            this.proTeleporting.Size = new System.Drawing.Size(166, 16);
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
            this.pnlTeleportOptions.Controls.Add(this.label6);
            this.pnlTeleportOptions.Controls.Add(this.trkIconSize);
            this.pnlTeleportOptions.Controls.Add(this.label2);
            this.pnlTeleportOptions.Controls.Add(this.txtRegion);
            this.pnlTeleportOptions.Controls.Add(this.nudX);
            this.pnlTeleportOptions.Controls.Add(this.label3);
            this.pnlTeleportOptions.Controls.Add(this.nudY);
            this.pnlTeleportOptions.Controls.Add(this.label5);
            this.pnlTeleportOptions.Controls.Add(this.nudZ);
            this.pnlTeleportOptions.Controls.Add(this.label4);
            this.pnlTeleportOptions.Location = new System.Drawing.Point(382, 0);
            this.pnlTeleportOptions.Name = "pnlTeleportOptions";
            this.pnlTeleportOptions.Size = new System.Drawing.Size(172, 240);
            this.pnlTeleportOptions.TabIndex = 3;
            this.pnlTeleportOptions.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlTeleportOptions_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Zoom";
            // 
            // trkIconSize
            // 
            this.trkIconSize.AutoSize = false;
            this.trkIconSize.LargeChange = 16;
            this.trkIconSize.Location = new System.Drawing.Point(42, 92);
            this.trkIconSize.Maximum = 128;
            this.trkIconSize.Minimum = 32;
            this.trkIconSize.Name = "trkIconSize";
            this.trkIconSize.Size = new System.Drawing.Size(127, 22);
            this.trkIconSize.SmallChange = 8;
            this.trkIconSize.TabIndex = 4;
            this.trkIconSize.TickFrequency = 32;
            this.trkIconSize.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkIconSize.Value = 100;
            this.trkIconSize.Scroll += new System.EventHandler(this.trkIconSize_Scroll);
            // 
            // button1
            // 
            this.button1.AccessibleName = "Teleport button";
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Enabled = false;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(382, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "&Open in browser";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmTeleport
            // 
            this.AccessibleName = "Teleport window";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(566, 389);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pnlTeleportOptions);
            this.Controls.Add(this.pnlTeleporting);
            this.Controls.Add(this.lbxRegionSearch);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTeleport);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtSearchFor);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTeleport";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Teleport";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTeleport_FormClosing);
            this.Load += new System.EventHandler(this.frmTeleport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudZ)).EndInit();
            this.pnlTeleporting.ResumeLayout(false);
            this.pnlTeleporting.PerformLayout();
            this.pnlTeleportOptions.ResumeLayout(false);
            this.pnlTeleportOptions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trkIconSize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchFor;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRegion;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudY;
        private System.Windows.Forms.NumericUpDown nudZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTeleport;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lbxRegionSearch;
        private System.Windows.Forms.Panel pnlTeleporting;
        private System.Windows.Forms.ProgressBar proTeleporting;
        private System.Windows.Forms.Label lblTeleportStatus;
        private System.Windows.Forms.Panel pnlTeleportOptions;
        private System.Windows.Forms.TrackBar trkIconSize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}