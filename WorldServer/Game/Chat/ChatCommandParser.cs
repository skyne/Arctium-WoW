﻿/*
 * Copyright (C) 2012 Arctium <http://>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 */

using System;
using System.Collections.Generic;
using System.Reflection;
using Framework.Configuration;
using WorldServer.Network;

namespace WorldServer.Game.Chat
{
    public class ChatCommandParser
    {
        public static Dictionary<string, HandleChatCommand> ChatCommands = new Dictionary<string, HandleChatCommand>();
        public delegate void HandleChatCommand(string[] args, ref WorldClass session);

        public static void DefineChatCommands()
        {
            Assembly currentAsm = Assembly.GetExecutingAssembly();
            foreach (var type in currentAsm.GetTypes())
            {
                foreach (var methodInfo in type.GetMethods())
                {
                    var chatAttr = methodInfo.GetCustomAttribute<ChatCommandAttribute>();
                    
                    if (chatAttr != null)
                        ChatCommands[chatAttr.ChatCommand] = (HandleChatCommand)Delegate.CreateDelegate(typeof(HandleChatCommand), methodInfo);
                }
            }
        }

        public static void ExecuteChatHandler(string chatCommand, ref WorldClass session)
        {
            var args = chatCommand.Split(new string[] { " " }, StringSplitOptions.None);
            var command = args[0].Remove(0, 1);

            if (ChatCommands.ContainsKey(command))
                ChatCommands[command].Invoke(args, ref session);
        }

        public static bool CheckForCommand(string command)
        {
            var commandStarts = WorldConfig.GMCommandStart.Split(new string[] { " " }, StringSplitOptions.None);

            foreach (string s in commandStarts)
                if (command.StartsWith(s))
                    return true;

            return false;
        }
    }
}
