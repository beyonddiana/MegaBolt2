namespace MEGAbolt
{
    partial class FriendsConsole
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FriendsConsole));
            this.lbxFriends = new System.Windows.Forms.ListBox();
            this.lblFriendName = new System.Windows.Forms.Label();
            this.btnIM = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnOfferTeleport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.chkSeeMeOnline = new System.Windows.Forms.CheckBox();
            this.chkSeeMeOnMap = new System.Windows.Forms.CheckBox();
            this.chkModifyMyObjects = new System.Windows.Forms.CheckBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbGroups = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.txtGroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbofgroups = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbxFriends
            // 
            this.lbxFriends.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbxFriends.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxFriends.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxFriends.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.lbxFriends.IntegralHeight = false;
            this.lbxFriends.ItemHeight = 20;
            this.lbxFriends.Location = new System.Drawing.Point(4, 0);
            this.lbxFriends.Name = "lbxFriends";
            this.lbxFriends.Size = new System.Drawing.Size(200, 415);
            this.lbxFriends.Sorted = true;
            this.lbxFriends.TabIndex = 0;
            this.lbxFriends.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.lbxFriends_DrawItem);
            this.lbxFriends.SelectedIndexChanged += new System.EventHandler(this.lbxFriends_SelectedIndexChanged);
            this.lbxFriends.DoubleClick += new System.EventHandler(this.lbxFriends_DoubleClick);
            this.lbxFriends.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbxFriends_MouseDown);
            // 
            // lblFriendName
            // 
            this.lblFriendName.AutoSize = true;
            this.lblFriendName.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendName.Location = new System.Drawing.Point(6, 17);
            this.lblFriendName.Name = "lblFriendName";
            this.lblFriendName.Size = new System.Drawing.Size(120, 13);
            this.lblFriendName.TabIndex = 1;
            this.lblFriendName.Text = "Getting friends list...";
            // 
            // btnIM
            // 
            this.btnIM.BackColor = System.Drawing.Color.DimGray;
            this.btnIM.Enabled = false;
            this.btnIM.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnIM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnIM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIM.ForeColor = System.Drawing.Color.White;
            this.btnIM.Location = new System.Drawing.Point(6, 47);
            this.btnIM.Name = "btnIM";
            this.btnIM.Size = new System.Drawing.Size(57, 23);
            this.btnIM.TabIndex = 2;
            this.btnIM.Text = "IM";
            this.btnIM.UseVisualStyleBackColor = false;
            this.btnIM.Click += new System.EventHandler(this.btnIM_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.BackColor = System.Drawing.Color.DimGray;
            this.btnProfile.Enabled = false;
            this.btnProfile.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnProfile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.Location = new System.Drawing.Point(70, 47);
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(75, 23);
            this.btnProfile.TabIndex = 3;
            this.btnProfile.Text = "Profile";
            this.btnProfile.UseVisualStyleBackColor = false;
            this.btnProfile.Click += new System.EventHandler(this.btnProfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnRemove);
            this.groupBox1.Controls.Add(this.btnPay);
            this.groupBox1.Controls.Add(this.btnOfferTeleport);
            this.groupBox1.Controls.Add(this.lblFriendName);
            this.groupBox1.Controls.Add(this.btnProfile);
            this.groupBox1.Controls.Add(this.btnIM);
            this.groupBox1.Location = new System.Drawing.Point(209, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 76);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.DimGray;
            this.btnRemove.Enabled = false;
            this.btnRemove.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRemove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(333, 47);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            this.btnRemove.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.DimGray;
            this.btnPay.Enabled = false;
            this.btnPay.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.ForeColor = System.Drawing.Color.White;
            this.btnPay.Location = new System.Drawing.Point(269, 47);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(58, 23);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "Pay...";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnOfferTeleport
            // 
            this.btnOfferTeleport.BackColor = System.Drawing.Color.DimGray;
            this.btnOfferTeleport.Enabled = false;
            this.btnOfferTeleport.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnOfferTeleport.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnOfferTeleport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfferTeleport.ForeColor = System.Drawing.Color.White;
            this.btnOfferTeleport.Location = new System.Drawing.Point(151, 47);
            this.btnOfferTeleport.Name = "btnOfferTeleport";
            this.btnOfferTeleport.Size = new System.Drawing.Size(112, 23);
            this.btnOfferTeleport.TabIndex = 4;
            this.btnOfferTeleport.Text = "Offer Teleport";
            this.btnOfferTeleport.UseVisualStyleBackColor = false;
            this.btnOfferTeleport.Click += new System.EventHandler(this.btnOfferTeleport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(209, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "This friend can:";
            // 
            // chkSeeMeOnline
            // 
            this.chkSeeMeOnline.AutoSize = true;
            this.chkSeeMeOnline.BackColor = System.Drawing.Color.Transparent;
            this.chkSeeMeOnline.Enabled = false;
            this.chkSeeMeOnline.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkSeeMeOnline.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSeeMeOnline.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSeeMeOnline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSeeMeOnline.Location = new System.Drawing.Point(218, 117);
            this.chkSeeMeOnline.Name = "chkSeeMeOnline";
            this.chkSeeMeOnline.Size = new System.Drawing.Size(122, 17);
            this.chkSeeMeOnline.TabIndex = 6;
            this.chkSeeMeOnline.Text = "See my online status";
            this.chkSeeMeOnline.UseVisualStyleBackColor = false;
            this.chkSeeMeOnline.CheckedChanged += new System.EventHandler(this.chkSeeMeOnline_CheckedChanged);
            // 
            // chkSeeMeOnMap
            // 
            this.chkSeeMeOnMap.AutoSize = true;
            this.chkSeeMeOnMap.BackColor = System.Drawing.Color.Transparent;
            this.chkSeeMeOnMap.Enabled = false;
            this.chkSeeMeOnMap.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkSeeMeOnMap.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSeeMeOnMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkSeeMeOnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkSeeMeOnMap.Location = new System.Drawing.Point(349, 117);
            this.chkSeeMeOnMap.Name = "chkSeeMeOnMap";
            this.chkSeeMeOnMap.Size = new System.Drawing.Size(115, 17);
            this.chkSeeMeOnMap.TabIndex = 7;
            this.chkSeeMeOnMap.Text = "See me on the map";
            this.chkSeeMeOnMap.UseVisualStyleBackColor = false;
            this.chkSeeMeOnMap.CheckedChanged += new System.EventHandler(this.chkSeeMeOnMap_CheckedChanged);
            // 
            // chkModifyMyObjects
            // 
            this.chkModifyMyObjects.AutoSize = true;
            this.chkModifyMyObjects.BackColor = System.Drawing.Color.Transparent;
            this.chkModifyMyObjects.Enabled = false;
            this.chkModifyMyObjects.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkModifyMyObjects.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkModifyMyObjects.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkModifyMyObjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkModifyMyObjects.Location = new System.Drawing.Point(484, 117);
            this.chkModifyMyObjects.Name = "chkModifyMyObjects";
            this.chkModifyMyObjects.Size = new System.Drawing.Size(110, 17);
            this.chkModifyMyObjects.TabIndex = 8;
            this.chkModifyMyObjects.Text = "Modify my objects";
            this.chkModifyMyObjects.UseVisualStyleBackColor = false;
            this.chkModifyMyObjects.CheckedChanged += new System.EventHandler(this.chkModifyMyObjects_CheckedChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(212, 200);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(483, 263);
            this.tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.AllowDrop = true;
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.lblGroupName);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.lbGroups);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(475, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friend Groups";
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.ForeColor = System.Drawing.Color.DimGray;
            this.lblGroupName.Location = new System.Drawing.Point(249, 70);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(32, 13);
            this.lblGroupName.TabIndex = 17;
            this.lblGroupName.Text = "None";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Selected group:";
            // 
            // textBox2
            // 
            this.textBox2.AccessibleName = "Drop inventory item box";
            this.textBox2.AllowDrop = true;
            this.textBox2.BackColor = System.Drawing.SystemColors.Info;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.DimGray;
            this.textBox2.Location = new System.Drawing.Point(252, 105);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(217, 21);
            this.textBox2.TabIndex = 15;
            this.textBox2.Text = "Drag-Drop friend to add to this group";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.Visible = false;
            this.textBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBox2_DragDrop);
            this.textBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.textBox2_DragEnter);
            // 
            // lbGroups
            // 
            this.lbGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbGroups.FormattingEnabled = true;
            this.lbGroups.Location = new System.Drawing.Point(7, 6);
            this.lbGroups.Name = "lbGroups";
            this.lbGroups.Size = new System.Drawing.Size(218, 223);
            this.lbGroups.Sorted = true;
            this.lbGroups.TabIndex = 0;
            this.lbGroups.SelectedIndexChanged += new System.EventHandler(this.lbGroups_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.txtGroup);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(475, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create a group";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(176, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txtGroup
            // 
            this.txtGroup.Location = new System.Drawing.Point(42, 83);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(209, 21);
            this.txtGroup.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Group name:";
            // 
            // cbofgroups
            // 
            this.cbofgroups.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbofgroups.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbofgroups.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbofgroups.FormattingEnabled = true;
            this.cbofgroups.Location = new System.Drawing.Point(4, 438);
            this.cbofgroups.Name = "cbofgroups";
            this.cbofgroups.Size = new System.Drawing.Size(199, 21);
            this.cbofgroups.Sorted = true;
            this.cbofgroups.TabIndex = 10;
            this.cbofgroups.SelectedIndexChanged += new System.EventHandler(this.cbofgroups_SelectedIndexChanged);
            this.cbofgroups.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbofgroups_KeyDown);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 421);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Currently displaying:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(218, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Remove from group";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FriendsConsole
            // 
            this.AllowDrop = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbofgroups);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.chkModifyMyObjects);
            this.Controls.Add(this.chkSeeMeOnMap);
            this.Controls.Add(this.chkSeeMeOnline);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbxFriends);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FriendsConsole";
            this.Size = new System.Drawing.Size(710, 466);
            this.Load += new System.EventHandler(this.FriendsConsole_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxFriends;
        private System.Windows.Forms.Label lblFriendName;
        private System.Windows.Forms.Button btnIM;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkSeeMeOnline;
        private System.Windows.Forms.CheckBox chkSeeMeOnMap;
        private System.Windows.Forms.CheckBox chkModifyMyObjects;
        private System.Windows.Forms.Button btnOfferTeleport;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox lbGroups;
        private System.Windows.Forms.Label lblGroupName;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cbofgroups;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtGroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}
