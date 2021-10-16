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
using METAbrain;
using System.Timers;
using MEGAbolt.NetworkComm;
using OpenMetaverse;
using System.Globalization;

namespace METAbolt
{
    public class METAbrain
    {
        private METAboltInstance instance;
        private MEGAboltNetcom netcom;
        public mBrain answer;

        //private ArrayList textBuffer;
        //private bool showTimestamps;
        private AIMLbot.Bot myBot = null;
        private AIMLbot.User myUser = null;
        private Timer metaTimer;
        private InstantMessageEventArgs emt;
        //private int cnt = 0;

        public METAbrain(METAboltInstance instance, AIMLbot.Bot myBot)
        {
            this.instance = instance;
            //client = this.instance.Client;
            netcom = this.instance.Netcom;
            this.myBot = myBot;

            answer = new mBrain();
        }

        public void StartProcess(InstantMessageEventArgs e)
        {
            emt = e;
            InitializeMetaTimer(emt.IM.Message.Length);
        }

        private void InitializeMetaTimer(int counter)
        {
            double timer_int = 3000;

            // Determine response time
            if (counter < 11)
            {
                timer_int = 2500;
            }
            else if ((counter > 10) && (counter < 31))
            {
                timer_int = 3000;
            }
            else if ((counter > 30) && (counter < 61))
            {
                timer_int = 4000;
            }
            else
            {
                timer_int = 6000;
            }

            //cnt += 1;

            // this is to buffer IM flood attacks
            //if (cnt < 16)
            //{
            metaTimer = new Timer(timer_int);

            metaTimer.Elapsed += metaTimer_Elapsed;

            metaTimer.Interval = timer_int;
            metaTimer.Enabled = true;
            metaTimer.Start();
            //}
        }

        private void metaTimer_Elapsed(object sender, ElapsedEventArgs e)
        {
            StartAI();
            //cnt -= 1;
        }

        private void StartAI()
        {
            metaTimer.Stop();
            metaTimer.Enabled = false;
            metaTimer.Dispose();

            string sanswer = answer.ProcessInput(emt.IM.Message.ToLower(CultureInfo.CurrentCulture), "");

            if (string.IsNullOrEmpty(sanswer))
            {
                string imsg = emt.IM.Message;
                imsg = answer.ProcessSmileys(imsg);

                ProcessAI(imsg, emt.IM.FromAgentName, emt.IM.FromAgentID, emt.IM.IMSessionID);
            }
            else
            {
                if (sanswer.Length > 0)
                    netcom.SendInstantMessage(sanswer, emt.IM.FromAgentID, emt.IM.IMSessionID);
            }
        }

        private void ProcessAI(string msg, string user, UUID target, UUID sess)
        {
            //string dland = "en";
            //MB_Translation_Utils.Utils trans = new MB_Translation_Utils.Utils();

            //if (instance.Config.CurrentConfig.MultiLingualAI)
            //{
            //    //dland = trans.DetectLanguageShortName(msg);

            //    //if (dland != "en")
            //    //{
            //    //    // translate to english
            //    //    msg = trans.Translate(msg, dland + "|en");
            //    //}
            //}

            string reply = GetResp(msg, user);

            if (string.IsNullOrEmpty(reply))
            {
                if (instance.Config.CurrentConfig.ReplyAI)
                {
                    reply = instance.Config.CurrentConfig.ReplyText;

                    if (string.IsNullOrEmpty(reply))
                    {
                        reply = "I am sorry but I didn't understand what you said or I haven't been taught a response for it. Can you try again, making sure your sentences are short and clear.";
                    }
                }
            }

            //if (instance.Config.CurrentConfig.MultiLingualAI)
            //{
            //    if (dland != "en")
            //    {
            //        reply = trans.Translate(reply, "en|" + dland);
            //    }
            //}

            netcom.SendInstantMessage(reply, target, sess);

            //trans = null;
        }

        public string GetResp(string msg, string user)
        {
            try
            {
                myUser = null;
                //GC.Collect();  

                myUser = new AIMLbot.User(user, myBot);

                AIMLbot.Request myRequest = new AIMLbot.Request(msg, myUser, myBot);
                AIMLbot.Result myResult = myBot.Chat(myRequest);

                string reply = myResult.Output;

                if (reply.Length > 5)
                {
                    if (reply.Substring(0, 5).ToLower(CultureInfo.CurrentCulture) == "error")
                    {
                        return string.Empty;
                    }

                    return reply;
                }

                return reply;
            }
            catch (Exception ex)
            {
                Logger.Log("There has been an error starting AI.", Helpers.LogLevel.Warning, ex);
                return string.Empty;
            }
        }
    }
}
