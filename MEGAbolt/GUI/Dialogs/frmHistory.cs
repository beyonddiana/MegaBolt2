﻿using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using OpenMetaverse;

namespace MEGAbolt
{
    public partial class frmHistory : Form
    {
        private MEGAboltInstance instance;
        private string filename = string.Empty;
        private SafeDictionary<string, string> ffiles = new SafeDictionary<string, string>();
        private bool isgroup = false;
        private GridClient client;
        private NumericStringComparerDateGroups lvwColumnSorter;

        public frmHistory(MEGAboltInstance instance, string filename, bool isgroup)
        {
            InitializeComponent();

            this.instance = instance;
            client = this.instance.Client;

            this.filename = filename;
            this.isgroup = isgroup; 

            GetHistory();

            lvwColumnSorter = new NumericStringComparerDateGroups
            {
                Order = SortOrder.Descending
            };
            lvwList.ListViewItemSorter = lvwColumnSorter;
        }

        private void GetHistory()
        {
            string folder = instance.Config.CurrentConfig.LogDir;

            if (!folder.EndsWith("\\", StringComparison.CurrentCultureIgnoreCase))
            {
                folder += "\\";
            }

            DirectoryInfo di = new DirectoryInfo(folder);
            FileSystemInfo[] files = di.GetFileSystemInfos();

            Array.Sort(files, CompareFileByDate);
            Array.Reverse(files);   // Descending 

            lvwList.Items.Clear();

            foreach (FileSystemInfo fi in files)
            {
                string inFile = fi.FullName;
                string finname = fi.Name;

                if (finname.Contains(filename))
                {
                    if (isgroup)
                    {
                        if (finname.Contains("-GROUP-"))
                        {
                            if (finname.Contains(client.Self.Name))
                            {
                                string filedate = string.Empty;
                                string[] file = finname.Split('-');

                                filedate = file[1].Trim() + "/" + file[2].Trim() + "/" + file[3].Substring(0, 4).Trim();

                                ffiles.Add(filedate, inFile);
                                lvwList.Items.Add(filedate);
                            }
                        }
                    }
                    else
                    {
                        if (!finname.Contains("-GROUP-"))
                        {
                            if (finname.Contains(client.Self.Name))
                            {
                                string filedate = string.Empty;
                                string[] file = finname.Split('-');

                                filedate = file[1].Trim() + "/" + file[2].Trim() + "/" + file[3].Substring(0, 4).Trim();

                                ffiles.Add(filedate, inFile);
                                lvwList.Items.Add(filedate);
                            }
                        }
                    }
                }
            }

            if (ffiles.Count() == 0)
            {
                label1.Text = "History for " + filename + " doesn't exist"; 
                return;
            }

            label1.Visible = false;

            lvwList.Sort();

            try
            {
                if (ffiles.ContainsKey(lvwList.Items[0].Text))
                {
                    GetFile(ffiles[lvwList.Items[0].Text]);
                }
            }
            catch
            {
                ;
            }
        }

        private void GetFile(string file)
        {
            try
            {
                rtbIMText.LoadFile(file, RichTextBoxStreamType.PlainText);
            }
            catch
            {
                ;
            }
        }

        private static int CompareFileByDate(FileSystemInfo f1, FileSystemInfo f2)
        {
            return DateTime.Compare(f1.LastWriteTime, f2.LastWriteTime);
        }

        private void rtbIMText_TextChanged(object sender, EventArgs e)
        {

        }

        private void lvwList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (ffiles.ContainsKey(lvwList.SelectedItems[0].Text))
                {
                    GetFile(ffiles[lvwList.SelectedItems[0].Text]);
                }
            }
            catch
            {
                ;
            }
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHistory_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void lvwList_Click(object sender, EventArgs e)
        {
            if (lvwList.SelectedItems.Count == 0) return;

            try
            {
                if (ffiles.ContainsKey(lvwList.SelectedItems[0].Text))
                {
                    GetFile(ffiles[lvwList.SelectedItems[0].Text]);
                }
            }
            catch
            {
                ;
            }
        }
    }
}
