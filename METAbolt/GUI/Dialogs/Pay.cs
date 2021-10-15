//  Copyright (c) 2008 - 2014, www.metabolt.net (METAbolt)
//  Copyright (c) 2006-2008, Paul Clement (a.k.a. Delta)
//  All rights reserved.

//  Redistribution and use in source and binary forms, with or without modification, 
//  are permitted provided that the following conditions are met:

//  * Redistributions of source code must retain the above copyright notice, 
//    this list of conditions and the following disclaimer. 
//  * Redistributions in binary form must reproduce the above copyright notice, 
//    this list of conditions and the following disclaimer in the documentation 
//    and/or other materials provided with the distribution. 

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

namespace METAbolt
{
    public partial class frmPay : Form
    {
        private METAboltInstance instance;
        private GridClient client;
        private UUID target = UUID.Zero;
        //private string name;
        private Primitive Prim = new Primitive();
        private int buyprice = -1;
        private int oprice = -1;

        public frmPay(METAboltInstance instance, UUID target, string name)
        {
            InitializeComponent();

            this.instance = instance;
            client = this.instance.Client;
            txtPerson.Text = name;
            txtPerson.Visible = true;
            label3.Visible = true;

            this.target = target;

            //LoadCallBacks();

            this.Text += "   " + "[ " + client.Self.Name + " ]";
        }

        public frmPay(METAboltInstance instance, UUID target, string name, string itemname)
        {
            InitializeComponent();

            this.instance = instance;
            client = this.instance.Client;
            //this.name = txtPerson.Text = name;
            textBox1.Text = itemname;

            this.target = target;

            LoadCallBacks();
        }

        public frmPay(METAboltInstance instance, UUID target, string name, int sprice)
        {
            InitializeComponent();

            this.instance = instance;
            client = this.instance.Client;

            this.target = target;
            this.nudAmount.Value = (decimal)sprice;

            LoadCallBacks();
        }

        public frmPay(METAboltInstance instance, UUID target, string name, string itemname, Primitive prim)
        {
            InitializeComponent();

            this.instance = instance;
            client = this.instance.Client;
            //this.name = txtPerson.Text = name;
            textBox1.Text = itemname;

            this.Prim = prim;

            this.target = target;

            LoadCallBacks();
        }

        public frmPay(METAboltInstance instance, UUID target, string name, int sprice, Primitive prim)
        {
            InitializeComponent();

            this.instance = instance;
            client = this.instance.Client;

            this.target = target;
            //this.name = txtPerson.Text = name;
            textBox1.Text = prim.Properties.Name;
            btnPay.Text = "&Buy"; 

            this.nudAmount.Value = (decimal)sprice;
            oprice = sprice;

            this.Prim = prim;

            LoadCallBacks();
        }

        private void LoadCallBacks()
        {
            client.Objects.PayPriceReply += PayPrice;

            client.Objects.RequestPayPrice(client.Network.CurrentSim, target);    
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            int iprice = (int)nudAmount.Value;

            if (Prim != null && Prim.ID != UUID.Zero)
            {
                SaleType styp = Prim.Properties.SaleType;

                if (styp != SaleType.Not)
                {
                    if (oprice != buyprice && buyprice != -1)
                    {
                        if (oprice < buyprice)
                        {
                            if (styp == SaleType.Contents)
                            {
                                client.Objects.BuyObject(client.Network.CurrentSim, Prim.LocalID, styp, iprice, client.Self.ActiveGroup, client.Inventory.Store.RootFolder.UUID);
                            }
                            else
                            {
                                UUID folderid = client.Inventory.FindFolderForType(AssetType.Object);   // instance.Config.CurrentConfig.ObjectsFolder;

                                client.Objects.BuyObject(client.Network.CurrentSim, Prim.LocalID, styp, iprice, client.Self.ActiveGroup, folderid);
                            }
                        }
                        else
                        {
                            client.Self.GiveObjectMoney(target, iprice, textBox1.Text.Trim());
                        }
                    }
                    else
                    {
                        if (styp == SaleType.Contents)
                        {
                            client.Objects.BuyObject(client.Network.CurrentSim, Prim.LocalID, styp, iprice, client.Self.ActiveGroup, client.Inventory.Store.RootFolder.UUID);
                        }
                        else
                        {
                            UUID folderid = client.Inventory.FindFolderForType(AssetType.Object);   // instance.Config.CurrentConfig.ObjectsFolder;

                            client.Objects.BuyObject(client.Network.CurrentSim, Prim.LocalID, styp, iprice, client.Self.ActiveGroup, folderid);
                        }
                    }
                }
                else
                {
                    client.Self.GiveObjectMoney(target, iprice, textBox1.Text.Trim());
                }
            }
            else
            {
                if (target != UUID.Zero)
                {
                    if (string.IsNullOrEmpty(textBox1.Text))
                    {
                        client.Self.GiveAvatarMoney(target, iprice);
                    }
                    else
                    {
                        client.Self.GiveAvatarMoney(target, iprice, textBox1.Text.Trim());
                    }
                }
            }

            this.Close();
        }

        private void frmPay_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
        }

        private void frmPay_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Objects.PayPriceReply -= PayPrice;
        }

        private void PayPrice(object sender, PayPriceReplyEventArgs e)
        {
            if (e.ObjectID != target) return;

            if (InvokeRequired)
            {
                BeginInvoke(new MethodInvoker(delegate()
                {
                    PayPrice(sender, e);
                }));

                return;
            }

            if (e.DefaultPrice > 0)
            {
                this.nudAmount.Value = (decimal)e.DefaultPrice;
                //SetNud(e.DefaultPrice);
                buyprice = e.DefaultPrice;
                btnPay.Text = "&Pay"; 
            }
            else if (e.DefaultPrice == -1)
            {
                this.nudAmount.Value = (decimal)e.ButtonPrices[0];
                //SetNud(e.ButtonPrices[0]);
                buyprice = e.ButtonPrices[0];
                btnPay.Text = "&Pay";
            }

            if (oprice != buyprice && buyprice != -1 & oprice != -1)
            {
                if (this.Prim.ClickAction == ClickAction.Buy || this.Prim.ClickAction == ClickAction.Pay)
                {
                    label5.Text = "Buy Price: L$" + oprice;
                    label5.Visible = true;
                }
            }
        }

        private void SetNud(int nprc)
        {
            //this.nudAmount.Minimum = (decimal)nprc;
        }
    }
}