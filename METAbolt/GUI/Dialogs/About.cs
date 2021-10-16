//  Copyright (c) 2008 - 2014, www.metabolt.net (METAbolt)
//  All rights reserved.

//  Redistribution and use in source and binary forms, with or without modification, 
//  are permitted provided that the following conditions are met:

//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright notice, 
//    this list of conditions and the following disclaimer in the documentation 
//    and/or other materials provided with the distribution. 
//  * Neither the name METAbolt nor the names of its contributors may be used to 
//    endorse or promote products derived from this software without specific prior 
//    written permission. 

//  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
//  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
//  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
//  IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
//  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
//  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
//  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
//  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
//  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
//  POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;
using System.Timers;


namespace METAbolt
{
    public partial class frmAbout : Form
    {
        private System.Timers.Timer scrollTimer;
        private int charCount = 0;
        private int row = 1;
        private bool stopscroll = false;


        public frmAbout()
        {
            InitializeComponent();

            lblVersion.Text = $"{Properties.Resources.METAboltTitle} V {Properties.Resources.METAboltVersion}";   
            txtDir.Text =  Application.StartupPath.ToString();
            textBox1.Text = DataFolder.GetDataFolder() ;
            //platform = Environment.GetEnvironmentVariable("PROCESSOR_ARCHITECTURE").ToString();

            //lblVersion.Text += " (" + Properties.Resources.PlatformType + ")";
            lblVersion.Text += " (" + Platform + ")";
        }

        public static string Platform
        {
            get
            {
                if (IntPtr.Size == 8)
                    return "64bit";
                else
                    return "32bit";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            CenterToParent();

            Thread thread = new Thread(ScrollRTB);
            thread.Start();
        }

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr ShellExecute(IntPtr hwnd,
                                          string lpOperation,
                                          string lpFile,
                                          string lpParameters,
                                          string lpDirectory,
                                          int nShowCmd
                                          );

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ShellExecute(this.Handle, "open", "mail:legolas.luke@yahoo.co.uk", null, null, 0);
            ShellExecute(Handle, "open", "http://www.metabolt.net/", null, null, 0);
        }

        private void lnkWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShellExecute(Handle, "open", "http://www.metabolt.net/metaforums/", null, null, 0);
        }

        private void lblVersion_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", txtDir.Text);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", textBox1.Text);
        }

        private void ScrollRTB()
        {
            scrollTimer = new System.Timers.Timer(1000);
            scrollTimer.Enabled = true;
            //scrollTimer.SynchronizingObject = this;
            scrollTimer.Elapsed += ScrollLine;
            scrollTimer.Start(); 
        }

        private void ScrollLine(object sender, ElapsedEventArgs e)
        {
            BeginInvoke(new MethodInvoker(delegate()
            {
                if (stopscroll) return;

                string line = richTextBox1.Lines[row - 1];

                charCount += line.Length + 1;

                row++;

                richTextBox1.SelectionStart = charCount;

                if (row == richTextBox1.Lines.Length + 1)
                {
                    //set the caret here
                    charCount = 0;
                    row = 1;
                    richTextBox1.SelectionStart = 0;
                }
            }));
        }

        private void frmAbout_FormClosing(object sender, FormClosingEventArgs e)
        {
            scrollTimer.Stop();
            scrollTimer.Enabled = false;
            scrollTimer.Dispose(); 
        }

        private void richTextBox1_MouseEnter(object sender, EventArgs e)
        {
            stopscroll = true;
        }

        private void richTextBox1_MouseLeave(object sender, EventArgs e)
        {
            stopscroll = false;
        }
    }
}