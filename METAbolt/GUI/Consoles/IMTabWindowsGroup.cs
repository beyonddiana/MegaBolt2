﻿//  Copyright (c) 2008 - 2014, www.metabolt.net (METAbolt)
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
using System.Collections.Generic;
using System.Windows.Forms;
using MEGAbolt.NetworkComm;
using OpenMetaverse;
using System.Threading;
using System.IO;
using System.Text.RegularExpressions;
using System.Web;
using System.Globalization;
using BugSplatDotNetStandard;
using WeCantSpell.Hunspell;


namespace METAbolt
{
    public partial class IMTabWindowGroup : UserControl
    {
        private METAboltInstance instance;
        private MEGAboltNetcom netcom;
        private UUID session;
        private GridClient client; 
        private string toName;
        private IMTextManager textManager;
        private bool typing = false;
        private OpenMetaverse.Group imgroup;
        //private bool pasted = false;
        private SafeDictionary<UUID, string> people = new SafeDictionary<UUID, string>();
        ManualResetEvent WaitForSessionStart = new ManualResetEvent(false);
        private UUID target = UUID.Zero;
        private const int WM_KEYUP = 0x101;
        private const int WM_KEYDOWN = 0x100;
        private TabsConsole tab;
        private bool hideparts = false;

        private WordList spellChecker = null;
        private string afffile = string.Empty;
        private string dicfile = string.Empty;
        private string dic = string.Empty;
        private string dir = METAbolt.DataFolder.GetDataFolder() + "\\Spelling\\";


        internal class ThreadExceptionHandler
        {
            public void ApplicationThreadException(object sender, ThreadExceptionEventArgs e)
            {
                BugSplat crashReporter = new BugSplat("radegast", "MEGAbolt",
                    Properties.Resources.METAboltVersion)
                {
                    User = "cinder@cinderblocks.biz",
                    ExceptionType = BugSplat.ExceptionTypeId.DotNetStandard
                };
                crashReporter.Post(e.Exception);
            }
        }
         
        public IMTabWindowGroup(METAboltInstance instance, UUID session, UUID target, string toName, OpenMetaverse.Group grp)
        {
            InitializeComponent();
            
            Application.ThreadException += new ThreadExceptionHandler().ApplicationThreadException;

            label1.Text = "Starting session with " + grp.Name + " please wait...";
            label1.Visible = true;

            this.instance = instance;
            netcom = this.instance.Netcom;
            client = this.instance.Client;

            afffile = this.instance.AffFile = instance.Config.CurrentConfig.SpellLanguage + ".aff";   // "en_GB.aff";
            dicfile = this.instance.DictionaryFile = instance.Config.CurrentConfig.SpellLanguage + ".dic";   // "en_GB.dic";

            this.target = target;
            this.session = session;
            //this.session = client.Self..AgentID ^ grp.ID;
            this.toName = toName;
            this.imgroup = grp;
            tab = instance.TabConsole;

            WaitForSessionStart.Reset();

            textManager = new IMTextManager(this.instance, new RichTextBoxPrinter(instance, rtbIMText), this.session, toName, grp);
            this.Disposed += IMTabWindow_Disposed;

            AddNetcomEvents();

            ApplyConfig(this.instance.Config.CurrentConfig);
            this.instance.Config.ConfigApplied += Config_ConfigApplied;

            //people = new SafeDictionary<UUID, string>();

            client.Self.GroupChatJoined += Self_OnGroupChatJoin;
            client.Self.ChatSessionMemberAdded += Self_OnChatSessionMemberAdded;
            client.Self.ChatSessionMemberLeft += Self_OnChatSessionMemberLeft;
            client.Avatars.UUIDNameReply += Avatars_OnAvatarNames;

            client.Self.RequestJoinGroupChat(session);
            CreateSmileys();

            if (this.instance.IMHistyoryExists(this.toName, true))
            {
                toolStripButton2.Enabled = true;
            }
        }

        private void Self_OnGroupChatJoin(object sender, GroupChatJoinedEventArgs e)
        {
            if (e.SessionID != session && e.TmpSessionID != session) return;
 
            if (e.Success)
            { 
                WaitForSessionStart.Set();

                BeginInvoke(new MethodInvoker(delegate()
                {
                    try
                    {
                        label1.Visible = false;
                    }
                    catch { ; }
                }));
            }
            else
            {
                //BeginInvoke(new MethodInvoker(Group_JoinError));
                BeginInvoke(new MethodInvoker(delegate()
                {
                    try
                    {
                        label1.Text = "Failed to join the requested group chat";
                    }
                    catch { ; }
                }));
            }
        }

        private void Self_OnChatSessionMemberAdded(object sender, ChatSessionMemberAddedEventArgs e)
        {
            if (e.SessionID != session) return;

            try
            {
                if (people == null)
                {
                    BeginInvoke(new MethodInvoker(delegate()
                    {
                        if (!lvwList.Items.ContainsKey(e.AgentID.ToString()))
                        {
                            ListViewItem item = lvwList.Items.Add(e.AgentID.ToString());
                            item.Tag = e;
                        }
                    }));

                    if (!people.ContainsKey(e.AgentID))
                    {
                        lock (people)
                        {
                            people.Add(e.AgentID, string.Empty);
                        }

                        client.Avatars.RequestAvatarName(e.AgentID);
                    }

                    return;
                }

                if (!people.ContainsKey(e.AgentID))
                {
                    BeginInvoke(new MethodInvoker(delegate()
                    {
                        if (!lvwList.Items.ContainsKey(e.AgentID.ToString()))
                        {
                            ListViewItem item = lvwList.Items.Add(e.AgentID.ToString());
                            item.Tag = e;
                        }
                    }));

                    if (!people.ContainsKey(e.AgentID))
                    {
                        lock (people)
                        {
                            people.Add(e.AgentID, string.Empty);
                        }
                    }

                    client.Avatars.RequestAvatarName(e.AgentID);
                }
                else
                {
                    BeginInvoke(new MethodInvoker(delegate()
                    {
                        if (!lvwList.Items.ContainsKey(people[e.AgentID]))
                        {
                            ListViewItem item = lvwList.Items.Add(people[e.AgentID]);
                            item.Tag = e;
                            lvwList.Sort();
                        }
                    }));
                }
            }
            catch { ; }
        }

        private void Self_OnChatSessionMemberLeft(object sender, ChatSessionMemberLeftEventArgs e)
        {
            if (e.SessionID == session)
            {
                BeginInvoke(new MethodInvoker(delegate()
                {
                    try
                    {
                        ListViewItem foundItem = lvwList.FindItemWithText(e.AgentID.ToString());

                        if (foundItem != null)
                        {
                            lvwList.Items.Remove(foundItem);
                        }
                    }
                    catch { ; }

                    try
                    {
                        if (people.ContainsKey(e.AgentID))
                        {
                            lock (people)
                            {
                                string person = people[e.AgentID];
                                ListViewItem foundItem2 = lvwList.FindItemWithText(person);

                                if (foundItem2 != null)
                                {
                                    lvwList.Items.Remove(foundItem2);
                                }

                                people.Remove(e.AgentID);
                            }
                        }
                    }
                    catch { ; }
                }));
            }
        }

        private void Avatars_OnAvatarNames(object sender, UUIDNameReplyEventArgs names)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate()
                {
                    Avatars_OnAvatarNames(sender, names);
                }));

                return;
            }
                
            BeginInvoke(new MethodInvoker(delegate()
            {
                UpdateChatList(names.Names);
            }));
        }

        private void UpdateChatList(Dictionary<UUID, string> names)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate()
                {
                    UpdateChatList(names);
                }));

                return;
            }

            if (names == null) return;

            if (lvwList.Items.Count > 0)
            {
                if (names.Count > 0)
                {
                    foreach (KeyValuePair<UUID, string> av in names)
                    {
                        if (people.ContainsKey(av.Key))
                        {
                            //ListViewItem foundItem = lvwList.FindItemWithText(av.Key.ToString(), false, 0, true);
                            ListViewItem foundItem = lvwList.FindItemWithText(av.Key.ToString());

                            try
                            {
                                if (foundItem != null)
                                {
                                    foundItem.Text = av.Value;

                                    lock (people)
                                    {
                                        people.Remove(av.Key);
                                        people.Add(av.Key, av.Value);
                                    }
                                }
                            }
                            catch
                            {
                                ;
                            }

                            lvwList.Sort();
                        }
                    }
                }
            }
        }

        private void CreateSmileys()
        {
            EmoticonMenuItem _menuItem;

            _menuItem = new EmoticonMenuItem(Smileys.AngelSmile);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[0].Tag = (object)"angelsmile;";

            _menuItem = new EmoticonMenuItem(Smileys.AngrySmile);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[1].Tag = "angry;";

            _menuItem = new EmoticonMenuItem(Smileys.Beer);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[2].Tag = "beer;";

            //_menuItem.BarBreak = true;

            _menuItem = new EmoticonMenuItem(Smileys.BrokenHeart);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[3].Tag = "brokenheart;";

            _menuItem = new EmoticonMenuItem(Smileys.bye);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[4].Tag = "bye";

            _menuItem = new EmoticonMenuItem(Smileys.clap);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[5].Tag = "clap;";

            _menuItem = new EmoticonMenuItem(Smileys.ConfusedSmile);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[6].Tag = ":S";

            _menuItem = new EmoticonMenuItem(Smileys.cool);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[7].Tag = "cool;";

            _menuItem = new EmoticonMenuItem(Smileys.CrySmile);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[8].Tag = "cry;";

            //_menuItem.BarBreak = true;

            _menuItem = new EmoticonMenuItem(Smileys.DevilSmile);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[9].Tag = "devil;";

            _menuItem = new EmoticonMenuItem(Smileys.duh);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[10].Tag = "duh;";

            _menuItem = new EmoticonMenuItem(Smileys.EmbarassedSmile);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[11].Tag = "embarassed;";

            _menuItem = new EmoticonMenuItem(Smileys.happy0037);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[12].Tag = ":)";

            _menuItem = new EmoticonMenuItem(Smileys.heart);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[13].Tag = "heart;";

            _menuItem = new EmoticonMenuItem(Smileys.kiss);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[14].Tag = "muah;";

            //_menuItem.BarBreak = true;

            _menuItem = new EmoticonMenuItem(Smileys.help);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[15].Tag = "help";

            _menuItem = new EmoticonMenuItem(Smileys.liar);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[16].Tag = "liar;";

            _menuItem = new EmoticonMenuItem(Smileys.lol);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[17].Tag = "lol";

            _menuItem = new EmoticonMenuItem(Smileys.oops);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[18].Tag = "oops";

            _menuItem = new EmoticonMenuItem(Smileys.sad);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[19].Tag = ":(";

            _menuItem = new EmoticonMenuItem(Smileys.shhh);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[20].Tag = "shhh";

            //_menuItem.BarBreak = true;

            _menuItem = new EmoticonMenuItem(Smileys.sigh);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[21].Tag = "sigh";

            _menuItem = new EmoticonMenuItem(Smileys.silenced);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[22].Tag = ":X";

            _menuItem = new EmoticonMenuItem(Smileys.think);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[23].Tag = "thinking;";

            _menuItem = new EmoticonMenuItem(Smileys.ThumbsUp);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[24].Tag = "thumbsup;";

            _menuItem = new EmoticonMenuItem(Smileys.whistle);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[25].Tag = "whistle;";

            _menuItem = new EmoticonMenuItem(Smileys.wink);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[26].Tag = ";)";

            //_menuItem.BarBreak = true;

            _menuItem = new EmoticonMenuItem(Smileys.wow);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[27].Tag = "wow";

            _menuItem = new EmoticonMenuItem(Smileys.yawn);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[28].Tag = "yawn;";

            _menuItem = new EmoticonMenuItem(Smileys.zzzzz);
            _menuItem.Click += cmenu_Emoticons_Click;
            cmenu_Emoticons.Items.Add(_menuItem);
            cmenu_Emoticons.Items[29].Tag = "zzzzz";

            _menuItem.Dispose(); 
        }

        // When an emoticon is clicked, insert its image into to RTF
        private void cmenu_Emoticons_Click(object _sender, EventArgs _args)
        {
            // Write the code here
            EmoticonMenuItem _item = (EmoticonMenuItem)_sender;

            cbxInput.Text += _item.Tag.ToString();
            cbxInput.Select(cbxInput.Text.Length, 0);
            //cbxInput.Focus();
        }

        private void Config_ConfigApplied(object sender, ConfigAppliedEventArgs e)
        {
            ApplyConfig(e.AppliedConfig);
        }

        private void ApplyConfig(Config config)
        {
            if (config.InterfaceStyle == 0) //System
                toolStrip1.RenderMode = ToolStripRenderMode.System;
            else if (config.InterfaceStyle == 1) //Office 2003
                toolStrip1.RenderMode = ToolStripRenderMode.ManagerRenderMode;

            //rtbIMText.BackColor = instance.Config.CurrentConfig.BgColour;

            if (instance.Config.CurrentConfig.EnableSpelling)
            {
                dicfile = instance.Config.CurrentConfig.SpellLanguage;   // "en_GB.dic";

                this.instance.AffFile = afffile = dicfile + ".aff";
                this.instance.DictionaryFile = dicfile + ".dic";

                dic = dir + dicfile;

                dicfile += ".dic";

                if (!System.IO.File.Exists(dic + ".csv"))
                {
                    //System.IO.File.Create(dic + ".csv");

                    using (StreamWriter sw = File.CreateText(dic + ".csv"))
                    {
                        sw.Dispose();
                    }
                }

                spellChecker = WordList.CreateFromFiles(dir + dicfile, dir + afffile);
            }
            else
            {
                spellChecker = null;
            }
        }

        private void AddNetcomEvents()
        {
            netcom.ClientLoginStatus += netcom_ClientLoginStatus;
            netcom.ClientDisconnected += netcom_ClientDisconnected;
        }

        private void RemoveNetcomEvents()
        {
            netcom.ClientLoginStatus -= netcom_ClientLoginStatus;
            netcom.ClientDisconnected -= netcom_ClientDisconnected;
        }

        private void netcom_ClientLoginStatus(object sender, LoginProgressEventArgs e)
        {
            if (e.Status != LoginStatus.Success) return;

            RefreshControls();
        }

        private void netcom_ClientDisconnected(object sender, DisconnectedEventArgs e)
        {
            RefreshControls();
        }

        private void IMTabWindow_Disposed(object sender, EventArgs e)
        {
            //client.Self.RequestLeaveGroupChat(target);
            client.Self.RequestLeaveGroupChat(session);
            CleanUp();
        }

        public void CleanUp()
        {
            //
            client.Self.GroupChatJoined -= Self_OnGroupChatJoin;
            client.Self.ChatSessionMemberAdded -= Self_OnChatSessionMemberAdded;
            client.Self.ChatSessionMemberLeft -= Self_OnChatSessionMemberLeft;
            client.Avatars.UUIDNameReply -= Avatars_OnAvatarNames;

            this.instance.Config.ConfigApplied -= Config_ConfigApplied;
            textManager.CleanUp();
            textManager = null;
            people = null;
            RemoveNetcomEvents();
        }

        private void SendIM(string message)
        {
            if (message.Length == 0) return;

            message = message.TrimEnd();

            message = instance.CleanReplace("http://secondlife:///", "secondlife:///", message);
            message = instance.CleanReplace("http://secondlife://", "secondlife:///", message);

            if (instance.Config.CurrentConfig.EnableSpelling)
            {
                // put preference check here
                //string cword = Regex.Replace(cbxInput.Text, @"[^a-zA-Z0-9]", "");
                //string[] swords = cword.Split(' ');
                string[] swords = message.Split(' ');
                bool hasmistake = false;
                bool correct = true;

                foreach (string word in swords)
                {
                    string cword = Regex.Replace(word, @"[^a-zA-Z0-9]", "");

                    try
                    {
                        correct = spellChecker.Check(cword);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "Dictionary is not loaded")
                        {
                            instance.Config.ApplyCurrentConfig();
                            //correct = hunspell.Spell(cword);
                        }
                        else
                        {
                            Logger.Log("Spellcheck error Group IM: " + ex.Message, Helpers.LogLevel.Error);
                        }
                    }

                    if (!correct)
                    {
                        hasmistake = true;
                        break;
                    }
                }

                if (hasmistake)
                {
                    (new frmSpelling(instance, message, swords, true, target, session)).Show();

                    ClearIMInput();
                    hasmistake = false;
                    return;
                }
            }

            string message1 = string.Empty;
            string message2 = string.Empty;

            if (message.Length > 1023)
            {
                message1 = message.Substring(0, 1022);
                netcom.SendInstantMessageGroup(message1, target, session);

                if (message.Length > 2046)
                {
                    message2 = message.Substring(1023, 2045);
                    netcom.SendInstantMessageGroup(message2, target, session);
                }
            }
            else
            {
                netcom.SendInstantMessageGroup(message, target, session); ;
            }

            this.ClearIMInput();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendIM(cbxInput.Text);

            //ClearIMInput();
        }

        private void cbxInput_TextChanged(object sender, EventArgs e)
        {
            RefreshControls();
        }

        private void RefreshControls()
        {
            if (!netcom.IsLoggedIn)
            {
                cbxInput.Enabled = false;
                btnSend.Enabled = false;
                return;
            }

            if (cbxInput.Text.Length > 0)
            {
                btnSend.Enabled = true;

                if (!typing)
                {
                    //netcom.SendIMStartTyping(target, session);
                    typing = true;
                }
            }
            else
            {
                btnSend.Enabled = false;
                //netcom.SendIMStopTyping(target, session);
                typing = false;
            }
        }

        private void ClearIMInput()
        {
            cbxInput.Items.Add(cbxInput.Text);
            cbxInput.Text = string.Empty;
        }

        public void SelectIMInput()
        {
            cbxInput.Select();
        }

        public UUID TargetId
        {
            get { return target; }
            set { target = value; }
        }

        public string TargetName
        {
            get { return toName; }
            set { toName = value; }
        }

        public UUID SessionId
        {
            get { return session; }
            set { session = value; }
        }

        public IMTextManager TextManager
        {
            get { return textManager; }
            set { textManager = value; }
        }

        private void tbtnProfile_Click(object sender, EventArgs e)
        {
            try
            {
                frmGroupInfo frm = new frmGroupInfo(imgroup, instance);
                frm.Show();
            }
            catch
            {
                ; 
            }
        }

        private void cbxInput_TextChanged_1(object sender, EventArgs e)
        {
            RefreshControls();
        }

        private void cbxInput_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) e.SuppressKeyPress = true;

            //if (e.Control && e.KeyCode == Keys.V)
            //{
            //    ClipboardAsync Clipboard2 = new ClipboardAsync();
            //    cbxInput.Text += Clipboard2.GetText(TextDataFormat.UnicodeText).Replace(Environment.NewLine, "\r\n");

            //    //pasted = true;
            //}
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //if ((keyData == (Keys.Control | Keys.C)))
            //{
            //    //your implementation
            //    return true;
            //}

            if ((keyData == (Keys.Control | Keys.V)))
            {
                //ClipboardAsync Clipboard2 = new ClipboardAsync();

                //string ptxt = Clipboard2.GetText(TextDataFormat.UnicodeText).Replace(Environment.NewLine, "\r\n");
                //cbxInput.Text += ptxt;
                //return true;

                ClipboardAsync Clipboard2 = new ClipboardAsync();

                string insertText = Clipboard2.GetText(TextDataFormat.UnicodeText).Replace(Environment.NewLine, "\r\n");
                int selectionIndex = cbxInput.SelectionStart;
                cbxInput.Text = cbxInput.Text.Insert(selectionIndex, insertText);
                cbxInput.SelectionStart = selectionIndex + insertText.Length;

                return true;
            }
            else
            {
                return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        private void cbxInput_KeyUp_1(object sender, KeyEventArgs e)
        {
            //if (pasted)
            //{
            //    int pos = cbxInput.SelectionStart;
            //    cbxInput.SelectionLength = cbxInput.Text.Length - pos;
            //    cbxInput.Text = cbxInput.SelectedText;
            //    pasted = false;
            //}

            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;

            if (cbxInput.Text.Length == 0) return;

            SendIM(cbxInput.Text);

            //this.ClearIMInput();
        }

        private void rtbIMText_LinkClicked_1(object sender, LinkClickedEventArgs e)
        {
            if (e.LinkText.StartsWith("http://slurl.", StringComparison.CurrentCultureIgnoreCase))
            {
                try
                {
                    // Open up the TP form here
                    string encoded = HttpUtility.UrlDecode(e.LinkText);
                    string[] split = encoded.Split(new Char[] { '/' });
                    //string[] split = e.LinkText.Split(new Char[] { '/' });
                    string simr = split[4].ToString();
                    double x = Convert.ToDouble(split[5].ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture);
                    double y = Convert.ToDouble(split[6].ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture);
                    double z = Convert.ToDouble(split[7].ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture);

                    (new frmTeleport(instance, simr, (float)x, (float)y, (float)z, false)).Show();
                }
                catch { ; }

            }
            else if (e.LinkText.StartsWith("http://maps.secondlife", StringComparison.CurrentCultureIgnoreCase))
            {
                try
                {
                    // Open up the TP form here
                    string encoded = HttpUtility.UrlDecode(e.LinkText);
                    string[] split = encoded.Split(new Char[] { '/' });
                    //string[] split = e.LinkText.Split(new Char[] { '/' });
                    string simr = split[4].ToString();
                    double x = Convert.ToDouble(split[5].ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture);
                    double y = Convert.ToDouble(split[6].ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture);
                    double z = Convert.ToDouble(split[7].ToString(CultureInfo.CurrentCulture), CultureInfo.CurrentCulture);

                    (new frmTeleport(instance, simr, (float)x, (float)y, (float)z, true)).Show();
                }
                catch { ; }

            }
            else if (e.LinkText.Contains("http://mbprofile:"))
            {
                try
                {
                    string encoded = HttpUtility.UrlDecode(e.LinkText);
                    string[] split = encoded.Split(new Char[] { '/' });
                    //string[] split = e.LinkText.Split(new Char[] { '#' });
                    string aavname = split[0].ToString();
                    string[] avnamesplit = aavname.Split(new Char[] { '#' });
                    aavname = avnamesplit[0].ToString();

                    split = e.LinkText.Split(new Char[] { ':' });
                    string elink = split[2].ToString(CultureInfo.CurrentCulture);
                    split = elink.Split(new Char[] { '&' });

                    UUID avid = (UUID)split[0].ToString();

                    (new frmProfile(instance, aavname, avid)).Show();
                }
                catch { ; }
            }
            else if (e.LinkText.Contains("http://secondlife:///"))
            {
                // Open up the Group Info form here
                string encoded = HttpUtility.UrlDecode(e.LinkText);
                string[] split = encoded.Split(new Char[] { '/' });
                UUID uuid = UUID.Zero;

                try
                {
                    uuid = (UUID)split[7].ToString();
                }
                catch
                {
                    uuid = UUID.Zero;
                }

                if (uuid != UUID.Zero && split[6].ToString(CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture) == "group")
                {
                    frmGroupInfo frm = new frmGroupInfo(uuid, instance);
                    frm.Show();
                }
                else if (uuid != UUID.Zero && split[6].ToString(CultureInfo.CurrentCulture).ToLower(CultureInfo.CurrentCulture) == "agent")
                {
                    (new frmProfile(instance, string.Empty, uuid)).Show();
                }
            }
            else if (e.LinkText.StartsWith("http://", StringComparison.CurrentCultureIgnoreCase) || e.LinkText.StartsWith("ftp://", StringComparison.CurrentCultureIgnoreCase) || e.LinkText.StartsWith("https://", StringComparison.CurrentCultureIgnoreCase))
            {
                System.Diagnostics.Process.Start(e.LinkText);
            }
            else
            {
                System.Diagnostics.Process.Start("http://" + e.LinkText);
            }
        }

        private void cbxInput_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            // Create a SaveFileDialog to request a path and file name to save to.
            SaveFileDialog saveFile1 = new SaveFileDialog();

            string logdir = METAbolt.DataFolder.GetDataFolder();
            logdir += "\\Logs\\";

            saveFile1.InitialDirectory = logdir; 

            // Initialize the SaveFileDialog to specify the RTF extension for the file.
            saveFile1.DefaultExt = "*.rtf";
            saveFile1.Filter = "txt files (*.txt)|*.txt|RTF Files (*.rtf)|*.rtf";  //"RTF Files|*.rtf";
            saveFile1.Title = "Save chat contents to hard disk...";

            // Determine if the user selected a file name from the saveFileDialog.
            if (saveFile1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               saveFile1.FileName.Length > 0)
            {
                // Save the contents of the RichTextBox into the file.
                rtbIMText.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
            }

            saveFile1.Dispose(); 
        }

        private void tsbClear_Click(object sender, EventArgs e)
        {
            textManager.ClearAllText();
        }

        private void rtbIMText_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lvwList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ChatSessionMemberAddedEventArgs av = ((ListViewItem)lvwList.SelectedItems[0]).Tag as ChatSessionMemberAddedEventArgs;
            if (av == null) return;

            (new frmProfile(instance, people[av.AgentID], av.AgentID)).Show();
        }

        private void lvwList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvwList_MouseEnter(object sender, EventArgs e)
        {
            lvwList.Cursor = Cursors.Hand;  
        }

        private void lvwList_MouseLeave(object sender, EventArgs e)
        {
            lvwList.Cursor = Cursors.Default;
        }

        protected override bool ProcessKeyPreview(ref System.Windows.Forms.Message m)
        {
            const int WM_CHAR = 0x102;
            const int WM_SYSCHAR = 0x106;
            const int WM_SYSKEYDOWN = 0x104;
            //const int WM_SYSKEYUP = 0x105;
            const int WM_IME_CHAR = 0x286;

            KeyEventArgs e = null;

            if ((m.Msg != WM_CHAR) && (m.Msg != WM_SYSCHAR) && (m.Msg != WM_IME_CHAR))
            {
                e = new KeyEventArgs(((Keys)((int)((long)m.WParam))) | ModifierKeys);
                if ((m.Msg == WM_KEYDOWN) || (m.Msg == WM_SYSKEYDOWN))
                {
                    TrappedKeyDown(e);
                }

                if (e.SuppressKeyPress)
                {
                    tab.tabs["chat"].Select();
                    METAboltTab stab = tab.GetTab(toName);
                    stab.Close();
                }

                if (e.Handled)
                {
                    return e.Handled;
                }
            }

            return base.ProcessKeyPreview(ref m);
        }

        private void TrappedKeyDown(KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.X)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (!hideparts)
            {
                splitContainer1.Panel1Collapsed = true;
                hideparts = true;
                toolStripButton1.Text = "Show participants";
            }
            else
            {
                splitContainer1.Panel1Collapsed = false;
                hideparts = false;
                toolStripButton1.Text = "Hide participants";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            frmHistory frm = new frmHistory(instance, toName, true);
            frm.Show();
        }
    }
}