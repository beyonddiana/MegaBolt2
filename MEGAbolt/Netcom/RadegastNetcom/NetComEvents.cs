/*
 * MEGAbolt Metaverse Client
 * Copyright(c) 2009-2014, Radegast Development Team
 * Copyright(c) 2016-2021, Sjofn, LLC
 * All rights reserved.
 *  
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *     * Redistributions of source code must retain the above copyright
 *       notice, this list of conditions and the following disclaimer.
 *     * Redistributions in binary form must reproduce the above copyright
 *       notice, this list of conditions and the following disclaimer in the
 *       documentation and/or other materials provided with the distribution.
 *     * Neither the name of the OpenSimulator Project nor the
 *       names of its contributors may be used to endorse or promote products
 *       derived from this software without specific prior written permission.
 *
 * THIS SOFTWARE IS PROVIDED BY THE DEVELOPERS ``AS IS'' AND ANY
 * EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
 * WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE
 * DISCLAIMED. IN NO EVENT SHALL THE CONTRIBUTORS BE LIABLE FOR ANY
 * DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
 * (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES;
 * LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND
 * ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 * (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS
 * SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */

using System;
using System.Collections.Generic;
using System.Text;
using OpenMetaverse;

namespace MEGAbolt.NetworkComm
{
    public partial class MEGAboltNetcom
    {
        // For the NetcomSync stuff
        private delegate void OnClientLoginRaise(LoginProgressEventArgs e);
        private delegate void OnClientLogoutRaise(EventArgs e);
        private delegate void OnClientDisconnectRaise(DisconnectedEventArgs e);
        private delegate void OnChatRaise(ChatEventArgs e);
        private delegate void OnScriptDialogRaise(ScriptDialogEventArgs e);
        private delegate void OnInstantMessageRaise(InstantMessageEventArgs e);
        private delegate void OnAlertMessageRaise(AlertMessageEventArgs e);
        private delegate void OnMoneyBalanceRaise(BalanceEventArgs e);
        private delegate void OnScriptQuestionRaise(ScriptQuestionEventArgs e);
        private delegate void OnLoadURLRaise(LoadUrlEventArgs e);
        private delegate void OnTeleportStatusRaise(TeleportEventArgs e);


        public event EventHandler<OverrideEventArgs> ClientLoggingIn;
        public event EventHandler<LoginProgressEventArgs> ClientLoginStatus;
        public event EventHandler<OverrideEventArgs> ClientLoggingOut;
        public event EventHandler ClientLoggedOut;
        public event EventHandler<DisconnectedEventArgs> ClientDisconnected;
        public event EventHandler<ChatEventArgs> ChatReceived;
        public event EventHandler<ScriptDialogEventArgs> ScriptDialogReceived;
        public event EventHandler<ChatSentEventArgs> ChatSent;
        public event EventHandler<InstantMessageEventArgs> InstantMessageReceived;
        public event EventHandler<InstantMessageSentEventArgs> InstantMessageSent;
        public event EventHandler<TeleportingEventArgs> Teleporting;
        public event EventHandler<TeleportEventArgs> TeleportStatusChanged;
        public event EventHandler<AlertMessageEventArgs> AlertMessageReceived;
        public event EventHandler<BalanceEventArgs> MoneyBalanceUpdated;
        public event EventHandler<ScriptQuestionEventArgs> ScriptQuestionReceived;
        public event EventHandler<LoadUrlEventArgs> LoadURLReceived;

        protected virtual void OnClientLoggingIn(OverrideEventArgs e)
        {
            ClientLoggingIn?.Invoke(this, e);
        }

        protected virtual void OnLoadURL(LoadUrlEventArgs e)
        {
            LoadURLReceived?.Invoke(this, e);
        }

        protected virtual void OnClientLoginStatus(LoginProgressEventArgs e)
        {
            ClientLoginStatus?.Invoke(this, e);
        }

        protected virtual void OnClientLoggingOut(OverrideEventArgs e)
        {
            ClientLoggingOut?.Invoke(this, e);
        }

        protected virtual void OnClientLoggedOut(EventArgs e)
        {
            ClientLoggedOut?.Invoke(this, e);
        }

        protected virtual void OnClientDisconnected(DisconnectedEventArgs e)
        {
            ClientDisconnected?.Invoke(this, e);
        }

        protected virtual void OnChatReceived(ChatEventArgs e)
        {
            ChatReceived?.Invoke(this, e);
        }

        protected virtual void OnScriptDialogReceived(ScriptDialogEventArgs e)
        {
            ScriptDialogReceived?.Invoke(this, e);

        }

        protected virtual void OnScriptQuestionReceived(ScriptQuestionEventArgs e)
        {
            ScriptQuestionReceived?.Invoke(this, e);

        }

        protected virtual void OnChatSent(ChatSentEventArgs e)
        {
            ChatSent?.Invoke(this, e);
        }

        protected virtual void OnInstantMessageReceived(InstantMessageEventArgs e)
        {
            InstantMessageReceived?.Invoke(this, e);
        }

        protected virtual void OnInstantMessageSent(InstantMessageSentEventArgs e)
        {
            InstantMessageSent?.Invoke(this, e);
        }

        protected virtual void OnTeleporting(TeleportingEventArgs e)
        {
            Teleporting?.Invoke(this, e);
        }

        protected virtual void OnTeleportStatusChanged(TeleportEventArgs e)
        {
            TeleportStatusChanged?.Invoke(this, e);
        }

        protected virtual void OnAlertMessageReceived(AlertMessageEventArgs e)
        {
            AlertMessageReceived?.Invoke(this, e);
        }

        protected virtual void OnMoneyBalanceUpdated(BalanceEventArgs e)
        {
            MoneyBalanceUpdated?.Invoke(this, e);
        }
    }
}
