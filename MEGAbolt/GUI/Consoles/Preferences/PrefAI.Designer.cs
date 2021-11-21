﻿namespace MEGAbolt
{
    partial class PrefAI
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
            this.label4 = new System.Windows.Forms.Label();
            this.picAI = new System.Windows.Forms.PictureBox();
            this.chkAI = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.chkReply = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAI)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(162, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "(requires MEGAbolt re-start)";
            // 
            // picAI
            // 
            this.picAI.Image = global::MEGAbolt.Properties.Resources.Help_and_Support_16;
            this.picAI.Location = new System.Drawing.Point(317, 28);
            this.picAI.Name = "picAI";
            this.picAI.Size = new System.Drawing.Size(15, 15);
            this.picAI.TabIndex = 17;
            this.picAI.TabStop = false;
            this.picAI.Click += new System.EventHandler(this.picAI_Click);
            this.picAI.MouseLeave += new System.EventHandler(this.picAI_MouseLeave);
            this.picAI.MouseHover += new System.EventHandler(this.picAI_MouseHover);
            // 
            // chkAI
            // 
            this.chkAI.AccessibleName = "Enable MEGAbrain option";
            this.chkAI.AutoSize = true;
            this.chkAI.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkAI.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkAI.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAI.Location = new System.Drawing.Point(12, 28);
            this.chkAI.Name = "chkAI";
            this.chkAI.Size = new System.Drawing.Size(131, 17);
            this.chkAI.TabIndex = 0;
            this.chkAI.Text = "Enable MEGAbrain (AI)";
            this.chkAI.UseVisualStyleBackColor = true;
            this.chkAI.CheckedChanged += new System.EventHandler(this.chkAI_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(31, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(301, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // trackBar1
            // 
            this.trackBar1.AutoSize = false;
            this.trackBar1.Location = new System.Drawing.Point(102, 49);
            this.trackBar1.Maximum = 20;
            this.trackBar1.Minimum = 5;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(104, 30);
            this.trackBar1.TabIndex = 19;
            this.trackBar1.TickFrequency = 5;
            this.trackBar1.Value = 5;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(43, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Chat range:";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(25, 19);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(181, 17);
            this.checkBox1.TabIndex = 17;
            this.checkBox1.Text = "Enable MEGAbrain in public chat";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AccessibleName = "MEGAbrain panel";
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.chkReply);
            this.panel1.Location = new System.Drawing.Point(28, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 186);
            this.panel1.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(137, 160);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "View AIML libraries";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(137, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "View configurations files";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Edit AI settings";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.AccessibleName = "Reply message textbox";
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Location = new System.Drawing.Point(30, 40);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(239, 82);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "I am sorry but I didn\'t understand what you said or I haven\'t been taught a respo" +
    "nse for it. Can you try again, making sure your sentences are short and clear.";
            // 
            // chkReply
            // 
            this.chkReply.AccessibleName = "Reply option";
            this.chkReply.AutoSize = true;
            this.chkReply.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.chkReply.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkReply.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.chkReply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkReply.Location = new System.Drawing.Point(9, 12);
            this.chkReply.Name = "chkReply";
            this.chkReply.Size = new System.Drawing.Size(242, 17);
            this.chkReply.TabIndex = 2;
            this.chkReply.Text = "Reply with below when an answer is not found";
            this.chkReply.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AccessibleName = "Enable multilingual AI";
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.checkBox2.FlatAppearance.CheckedBackColor = System.Drawing.Color.LightSteelBlue;
            this.checkBox2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.checkBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox2.Location = new System.Drawing.Point(37, 57);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(126, 17);
            this.checkBox2.TabIndex = 20;
            this.checkBox2.Text = "Enable multi-lingual AI";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // PrefAI
            // 
            this.AccessibleName = "AI tab";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.picAI);
            this.Controls.Add(this.chkAI);
            this.Name = "PrefAI";
            this.Size = new System.Drawing.Size(344, 300);
            this.Load += new System.EventHandler(this.PrefAI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picAI;
        private System.Windows.Forms.CheckBox chkAI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chkReply;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
    }
}
