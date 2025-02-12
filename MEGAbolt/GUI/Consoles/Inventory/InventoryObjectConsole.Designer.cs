namespace MEGAbolt
{
    partial class InventoryObjectConsole
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
            this.btnRezObject = new System.Windows.Forms.Button();
            this.btnTouch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Object Options";
            // 
            // btnRezObject
            // 
            this.btnRezObject.AccessibleName = "Rez button";
            this.btnRezObject.BackColor = System.Drawing.Color.DimGray;
            this.btnRezObject.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnRezObject.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnRezObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezObject.ForeColor = System.Drawing.Color.White;
            this.btnRezObject.Location = new System.Drawing.Point(3, 28);
            this.btnRezObject.Name = "btnRezObject";
            this.btnRezObject.Size = new System.Drawing.Size(108, 23);
            this.btnRezObject.TabIndex = 0;
            this.btnRezObject.Text = "Re&z Inworld";
            this.btnRezObject.UseVisualStyleBackColor = false;
            this.btnRezObject.Click += new System.EventHandler(this.btnRezObject_Click);
            // 
            // button1
            // 
            this.btnTouch.AccessibleName = "Touch button";
            this.btnTouch.BackColor = System.Drawing.Color.DimGray;
            this.btnTouch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnTouch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnTouch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTouch.ForeColor = System.Drawing.Color.White;
            this.btnTouch.Location = new System.Drawing.Point(117, 28);
            this.btnTouch.Name = "btnTouch";
            this.btnTouch.Size = new System.Drawing.Size(70, 23);
            this.btnTouch.TabIndex = 1;
            this.btnTouch.Text = "Touc&h";
            this.btnTouch.UseVisualStyleBackColor = false;
            this.btnTouch.Visible = false;
            this.btnTouch.Click += new System.EventHandler(this.btnTouch_Click);
            // 
            // InventoryObjectConsole
            // 
            this.AccessibleName = "Object console";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnTouch);
            this.Controls.Add(this.btnRezObject);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "InventoryObjectConsole";
            this.Size = new System.Drawing.Size(306, 305);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRezObject;
        private System.Windows.Forms.Button btnTouch;
    }
}
