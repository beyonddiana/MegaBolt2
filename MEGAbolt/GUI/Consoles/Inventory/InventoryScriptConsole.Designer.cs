namespace MEGAbolt
{
    partial class InventoryScriptConsole
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditScript = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Script Options";
            // 
            // btnEditScript
            // 
            this.btnEditScript.AccessibleName = "View button";
            this.btnEditScript.BackColor = System.Drawing.Color.DimGray;
            this.btnEditScript.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnEditScript.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnEditScript.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditScript.ForeColor = System.Drawing.Color.White;
            this.btnEditScript.Location = new System.Drawing.Point(3, 28);
            this.btnEditScript.Name = "btnEditScript";
            this.btnEditScript.Size = new System.Drawing.Size(116, 23);
            this.btnEditScript.TabIndex = 0;
            this.btnEditScript.Text = "&View/Edit Script";
            this.btnEditScript.UseVisualStyleBackColor = false;
            this.btnEditScript.Click += new System.EventHandler(this.btnEditScript_Click);
            // 
            // InventoryScriptConsole
            // 
            this.AccessibleName = "Script console";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnEditScript);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InventoryScriptConsole";
            this.Size = new System.Drawing.Size(306, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditScript;
    }
}
