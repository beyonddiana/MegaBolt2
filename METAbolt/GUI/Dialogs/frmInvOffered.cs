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
using System.Windows.Forms;
using OpenMetaverse;
using System.Media;
using System.Threading;
using System.Globalization;
using BugSplatDotNetStandard;

namespace METAbolt
{
    public partial class frmInvOffered : Form
    {
        private METAboltInstance instance;
        private GridClient client;
        private InstantMessage msg;
        private UUID objectID;
        //private bool diainv = false;
        private AssetType invtype = AssetType.Unknown;
        private bool printed = false;
        private InstantMessageDialog diag;

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

        public frmInvOffered(METAboltInstance instance, InstantMessage e, UUID objectID, AssetType type)
        {
            InitializeComponent();
            
            Application.ThreadException += new ThreadExceptionHandler().ApplicationThreadException;

            this.instance = instance;
            client = this.instance.Client;
            msg = e;
            this.objectID = objectID;
            this.Text += " [" + client.Self.Name + "]";

            invtype = type;

            if (invtype == AssetType.Folder)
            {
                instance.State.FolderRcvd = true;
            }
            else
            {
                instance.State.FolderRcvd = false;
            }

            diag = e.Dialog;

            //if (e.Dialog == InstantMessageDialog.TaskInventoryOffered)
            //{
            //    diainv = true;
            //}

            string a = "a";

            if (type.ToString().ToLower(CultureInfo.CurrentCulture).StartsWith("a", StringComparison.CurrentCultureIgnoreCase) || type.ToString().ToLower(CultureInfo.CurrentCulture).StartsWith("o", StringComparison.CurrentCultureIgnoreCase) || type.ToString().ToLower(CultureInfo.CurrentCulture).StartsWith("u", StringComparison.CurrentCultureIgnoreCase))
            {
                a = "an";
            }

            lblSubheading.Text = "You have received " + a + " " + type.ToString() + " named '" + e.Message + "' from " + e.FromAgentName;

            if (instance.Config.CurrentConfig.PlayInventoryItemReceived)
            {
                SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.Item_received);
                simpleSound.Play();
                simpleSound.Dispose();
            }

            timer1.Interval = instance.DialogTimeOut;
            timer1.Enabled = true;
            timer1.Start();

            DateTime dte = DateTime.Now.AddMinutes(15.0d);

            label1.Text = "This item will be auto accepted @ " + dte.ToShortTimeString();

            this.Text += "   " + "[ " + client.Self.Name + " ]";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            client.Inventory.RemoveItem(objectID);

            //DataRow dr = instance.MuteList.NewRow();
            //dr["uuid"] = msg.FromAgentID;
            //dr["mute_name"] = msg.FromAgentName;
            //instance.MuteList.Rows.Add(dr);

            if (diag == InstantMessageDialog.TaskInventoryOffered)
            {
                if (instance.IsObjectMuted(msg.FromAgentID, msg.FromAgentName))
                {
                    MessageBox.Show(msg.FromAgentName + " is already in your mute list.", "MEGAbolt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                instance.Client.Self.UpdateMuteListEntry(MuteType.Object, msg.FromAgentID, msg.FromAgentName);
            }
            else
            {
                if (instance.IsAvatarMuted(msg.FromAgentID, msg.FromAgentName))
                {
                    MessageBox.Show(msg.FromAgentName + " is already in your mute list.", "MEGAbolt", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                instance.Client.Self.UpdateMuteListEntry(MuteType.Resident, msg.FromAgentID, msg.FromAgentName);
            }

            MessageBox.Show(msg.FromAgentName + " is now muted.", "MEGAbolt", MessageBoxButtons.OK, MessageBoxIcon.Information);

            timer1.Stop();
            timer1.Enabled = false;

            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                UUID invfolder = UUID.Zero;

                if (invtype == AssetType.Folder)
                {
                    instance.State.FolderRcvd = true;
                    invfolder = client.Inventory.Store.RootFolder.UUID;
                }
                else
                {
                    instance.State.FolderRcvd = false;
                    invfolder = client.Inventory.FindFolderForType(invtype);
                }

                if (diag == InstantMessageDialog.InventoryOffered)
                {
                    client.Self.InstantMessage(client.Self.Name, msg.FromAgentID, string.Empty, msg.IMSessionID, InstantMessageDialog.InventoryAccepted, InstantMessageOnline.Offline, instance.SIMsittingPos(), client.Network.CurrentSim.RegionID, invfolder.GetBytes());   //  new byte[0]); // Accept Inventory Offer
                    client.Inventory.RequestFetchInventory(objectID, client.Self.AgentID);
                }
                else if (diag == InstantMessageDialog.TaskInventoryOffered)
                {
                    client.Self.InstantMessage(client.Self.Name, msg.FromAgentID, string.Empty, msg.IMSessionID, InstantMessageDialog.TaskInventoryAccepted, InstantMessageOnline.Offline, instance.SIMsittingPos(), client.Network.CurrentSim.RegionID, invfolder.GetBytes()); // Accept TaskInventory Offer
                    client.Inventory.RequestFetchInventory(objectID, client.Self.AgentID);
                }
                else
                {
                    timer1.Stop();
                    timer1.Enabled = false;
                    //this.Close();
                }

                timer1.Stop();
                timer1.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has been encountered but the item\nshould have been saved into your inventory:\n" + ex.Message, "MEGAbolt");  
            }
            
            this.Close();
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            try
            {
                //UUID invfolder = client.Inventory.FindFolderForType(invtype);

                UUID invfolder = UUID.Zero;

                if (invtype == AssetType.Folder)
                {
                    instance.State.FolderRcvd = true;
                    invfolder = client.Inventory.Store.RootFolder.UUID;
                }
                else
                {
                    instance.State.FolderRcvd = false;
                    invfolder = client.Inventory.FindFolderForType(invtype);
                }

                if (diag == InstantMessageDialog.InventoryOffered)
                {
                    client.Self.InstantMessage(client.Self.Name, msg.FromAgentID, string.Empty, msg.IMSessionID, InstantMessageDialog.InventoryDeclined, InstantMessageOnline.Offline, instance.SIMsittingPos(), client.Network.CurrentSim.RegionID, invfolder.GetBytes()); // Decline Inventory Offer

                    try
                    {
                        //client.Inventory.RemoveItem(objectID);
                        //client.Inventory.RequestFetchInventory(objectID, client.Self.AgentID);

                        InventoryBase item = client.Inventory.Store.Items[objectID].Data;
                        UUID content = client.Inventory.FindFolderForType(FolderType.Trash);

                        InventoryFolder folder = (InventoryFolder)client.Inventory.Store.Items[content].Data;

                        if (invtype != AssetType.Folder)
                        {
                            client.Inventory.Move(item, folder, item.Name);
                        }
                        else
                        {
                            client.Inventory.MoveFolder(objectID, content, item.Name);
                        }
                    }
                    catch { ; }
                }
                else if (diag == InstantMessageDialog.TaskInventoryOffered)
                {
                    client.Self.InstantMessage(client.Self.Name, msg.FromAgentID, string.Empty, msg.IMSessionID, InstantMessageDialog.TaskInventoryDeclined, InstantMessageOnline.Offline, instance.SIMsittingPos(), client.Network.CurrentSim.RegionID, invfolder.GetBytes()); // Decline Inventory Offer
                }

                timer1.Stop();
                timer1.Enabled = false;
            }
            catch
            {
                ;                
            }

            this.Close();
        }

        private void frmInvOffered_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //btnDecline.PerformClick();

            timer1.Enabled = false;
            timer1.Stop();

            //instance.TabConsole.DisplayChatScreen("'Inventory offer' from " + msg.FromAgentName + " has timed out and the item has been moved to your trash: " + msg.Message + " (" + invtype.ToString() + ")");

            if (!printed)
            {
                instance.TabConsole.DisplayChatScreen(" 'Inventory offer' from " + msg.FromAgentName + " has timed out and the item named '" + msg.Message + "' has been saved to your " + invtype.ToString() + " folder. ");
            }

            printed = true;

            btnAccept.PerformClick();

            //timer1.Dispose();

            this.Close();
        }

        private void frmInvOffered_MouseEnter(object sender, EventArgs e)
        {
            this.Opacity = 100;
        }

        private void frmInvOffered_MouseLeave(object sender, EventArgs e)
        {
            this.Opacity = 75;
        }
    }
}
