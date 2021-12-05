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
using System.Windows.Forms;
using System.Globalization;

namespace MEGAbolt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MEGAbolt.Core.NativeMethods.Init();

            if (args.Length > 0)
            {
                if (args.Length != 3)
                {
                    MessageBox.Show("Command line usage: metabolt.exe [firstname] [lastname] [password]","MEGAbolt",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MEGAboltInstance instance = new MEGAboltInstance(true, args);
                    Application.Run(instance.MainForm);
                    instance = null;
                }
            }
            else
            {
                try
                {
                    MEGAboltInstance instance = new MEGAboltInstance(true);
                    Application.Run(instance.MainForm);
                    instance = null;
                }
                catch (Exception ex)
                {
                    //messagebox of last resort
                    DialogResult res = MessageBox.Show(string.Format(CultureInfo.CurrentCulture,
                        "Message: {0}, From: {1}, Stack: {2}", ex.Message, ex.Source, ex.StackTrace),
                        "MEGAbolt has encountered an unrecovarable error", MessageBoxButtons.RetryCancel, 
                        MessageBoxIcon.Exclamation);
                    if (res != DialogResult.Retry) { throw ex; }
                }
            } 
        }
    }
}