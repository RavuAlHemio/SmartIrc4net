/**
 * $Id: Logger.cs,v 1.1 2003/11/16 16:58:42 meebey Exp $
 * $Revision: 1.1 $
 * $Author: meebey $
 * $Date: 2003/11/16 16:58:42 $
 *
 * Copyright (c) 2003 Mirco 'meebey' Bauer <mail@meebey.net> <http://www.meebey.net>
 * 
 * Full LGPL License: <http://www.gnu.org/licenses/lgpl.txt>
 * 
 * This library is free software; you can redistribute it and/or
 * modify it under the terms of the GNU Lesser General Public
 * License as published by the Free Software Foundation; either
 * version 2.1 of the License, or (at your option) any later version.
 *
 * This library is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
 * Lesser General Public License for more details.
 *
 * You should have received a copy of the GNU Lesser General Public
 * License along with this library; if not, write to the Free Software
 * Foundation, Inc., 59 Temple Place, Suite 330, Boston, MA  02111-1307  USA
 */

using System;
using System.IO;
using System.Collections;

namespace SmartIRC
{
    public class Logger
    {
        private static SortedList _LoggerList = new SortedList();

        private Logger()
        {
        }

        public static void Init()
        {
            log4net.Config.DOMConfigurator.ConfigureAndWatch(new FileInfo("SmartIRC#-log.config"));
            _LoggerList[Category.Main]           = log4net.LogManager.GetLogger("MAIN");
            _LoggerList[Category.Socket]         = log4net.LogManager.GetLogger("SOCKET");
            _LoggerList[Category.Connection]     = log4net.LogManager.GetLogger("CONNECTION");
            _LoggerList[Category.IrcMessages]    = log4net.LogManager.GetLogger("IRCMESSAGE");
            _LoggerList[Category.MessageParser]  = log4net.LogManager.GetLogger("MESSAGEPARSER");
            _LoggerList[Category.MessageTypes]   = log4net.LogManager.GetLogger("MESSAGETYPES");
            _LoggerList[Category.ActionHandler]  = log4net.LogManager.GetLogger("ACTIONHANDLER");
            _LoggerList[Category.TimeHandler]    = log4net.LogManager.GetLogger("TIMEHANDLER");
            _LoggerList[Category.MessageHandler] = log4net.LogManager.GetLogger("MESSAGEHANDLER");
            _LoggerList[Category.ChannelSyncing] = log4net.LogManager.GetLogger("CHANNELSYNCING");
            _LoggerList[Category.UserSyncing]    = log4net.LogManager.GetLogger("USERSYNCING");
            _LoggerList[Category.Modules]        = log4net.LogManager.GetLogger("MODULES");
            _LoggerList[Category.DCC]            = log4net.LogManager.GetLogger("DCC");
        }

        public static log4net.ILog Main
        {
            get {
                return (log4net.ILog)_LoggerList[Category.Main];
            }
        }

        public static log4net.ILog Socket
        {
            get {
                return (log4net.ILog)_LoggerList[Category.Socket];
            }
        }

        public static log4net.ILog Connection
        {
            get {
                return (log4net.ILog)_LoggerList[Category.Connection];
            }
        }

        public static log4net.ILog IrcMessages
        {
            get {
                return (log4net.ILog)_LoggerList[Category.IrcMessages];
            }
        }

        public static log4net.ILog MessageParser
        {
            get {
                return (log4net.ILog)_LoggerList[Category.MessageParser];
            }
        }

        public static log4net.ILog MessageTypes
        {
            get {
                return (log4net.ILog)_LoggerList[Category.MessageTypes];
            }
        }

        public static log4net.ILog ActionHandler
        {
            get {
                return (log4net.ILog)_LoggerList[Category.ActionHandler];
            }
        }

        public static log4net.ILog TimeHandler
        {
            get {
                return (log4net.ILog)_LoggerList[Category.TimeHandler];
            }
        }

        public static log4net.ILog MessageHandler
        {
            get {
                return (log4net.ILog)_LoggerList[Category.MessageHandler];
            }
        }

        public static log4net.ILog ChannelSyncing
        {
            get {
                return (log4net.ILog)_LoggerList[Category.ChannelSyncing];
            }
        }

        public static log4net.ILog UserSyncing
        {
            get {
                return (log4net.ILog)_LoggerList[Category.UserSyncing];
            }
        }

        public static log4net.ILog Modules
        {
            get {
                return (log4net.ILog)_LoggerList[Category.Modules];
            }
        }

        public static log4net.ILog DCC
        {
            get {
                return (log4net.ILog)_LoggerList[Category.DCC];
            }
        }
    }
}
