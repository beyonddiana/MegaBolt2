/*
 * MEGAbolt Metaverse Client
 * Copyright(c) 2008-2014, www.metabolt.net (METAbolt)
 * Copyright(c) 2021, Sjofn, LLC
 * All rights reserved.
 *  
 * Radegast is free software: you can redistribute it and/or modify
 * it under the terms of the GNU Lesser General Public License as published
 * by the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU Lesser General Public License
 * along with this program.If not, see<https://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Text;
using OpenMetaverse;

namespace MEGAbolt.NetworkComm
{
    public class InstantMessageSentEventArgs : EventArgs
    {
        public InstantMessageSentEventArgs(string message, UUID targetID, UUID sessionID, DateTime timestamp)
        {
            Message = message;
            TargetID = targetID;
            SessionID = sessionID;
            Timestamp = timestamp;
        }

        public InstantMessageSentEventArgs(string message, UUID targetID, UUID sessionID, DateTime timestamp, Boolean isGrp)
        {
            Message = message;
            TargetID = targetID;
            SessionID = sessionID;
            Timestamp = timestamp;
            GroupIM = isGrp; 
        }

        public Boolean GroupIM { get; }

        public string Message { get; }

        public UUID TargetID { get; }

        public UUID SessionID { get; }

        public DateTime Timestamp { get; }
    }
}