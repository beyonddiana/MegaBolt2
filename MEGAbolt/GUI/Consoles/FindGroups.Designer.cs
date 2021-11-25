﻿namespace MEGAbolt
{
    partial class FindGroups
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
            this.lvwFindGroups = new System.Windows.Forms.ListView();
            this.chdGroupName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chdDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pGroups = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pGroups)).BeginInit();
            this.SuspendLayout();
            // 
            // lvwFindGroups
            // 
            this.lvwFindGroups.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lvwFindGroups.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvwFindGroups.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chdGroupName,
            this.chdDescription});
            this.lvwFindGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwFindGroups.FullRowSelect = true;
            this.lvwFindGroups.Location = new System.Drawing.Point(0, 0);
            this.lvwFindGroups.MultiSelect = false;
            this.lvwFindGroups.Name = "lvwFindGroups";
            this.lvwFindGroups.Size = new System.Drawing.Size(522, 361);
            this.lvwFindGroups.TabIndex = 1;
            this.lvwFindGroups.UseCompatibleStateImageBehavior = false;
            this.lvwFindGroups.View = System.Windows.Forms.View.Details;
            this.lvwFindGroups.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvwFindGroups_ColumnClick);
            this.lvwFindGroups.SelectedIndexChanged += new System.EventHandler(this.lvwFindGroups_SelectedIndexChanged);
            // 
            // chdGroupName
            // 
            this.chdGroupName.Text = "Group";
            this.chdGroupName.Width = 205;
            // 
            // chdDescription
            // 
            this.chdDescription.Text = "Description";
            this.chdDescription.Width = 350;
            // 
            // pGroups
            // 
            this.pGroups.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pGroups.Image = global::MEGAbolt.Properties.Resources.wait30trans;
            this.pGroups.Location = new System.Drawing.Point(247, 168);
            this.pGroups.Name = "pGroups";
            this.pGroups.Size = new System.Drawing.Size(30, 30);
            this.pGroups.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pGroups.TabIndex = 46;
            this.pGroups.TabStop = false;
            this.pGroups.Visible = false;
            this.pGroups.Click += new System.EventHandler(this.pGroups_Click);
            // 
            // FindGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pGroups);
            this.Controls.Add(this.lvwFindGroups);
            this.Name = "FindGroups";
            this.Size = new System.Drawing.Size(522, 361);
            ((System.ComponentModel.ISupportInitialize)(this.pGroups)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvwFindGroups;
        private System.Windows.Forms.ColumnHeader chdGroupName;
        private System.Windows.Forms.ColumnHeader chdDescription;
        private System.Windows.Forms.PictureBox pGroups;
    }
}
