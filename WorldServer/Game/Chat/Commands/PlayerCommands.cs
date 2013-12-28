using Framework.Console.Commands;
using Framework.Constants;
using Framework.ObjectDefines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorldServer.Game.Packets.PacketHandler;
using WorldServer.Game.WorldEntities;
using WorldServer.Network;

namespace WorldServer.Game.Chat.Commands
{
    public class PlayerCommands : Globals
    {
        [ChatCommand("learn")]
        public static void LearnSpell(string[] args, WorldClass session)
        {
            if (session.Character.TargetGuid == 0)
            {
                ChatHandler.SendMessage(ref session, new ChatMessageValues(MessageType.ChatMessageSystem, "Theres no targeted character to teach."));
                return;
            }

            var target = new Character(session.Character.TargetGuid);

            uint spellId = CommandParser.Read<uint>(args, 1);
            
            try
            {
                SpellMgr.AddSpell(target, spellId);
            }
            catch(Exception e)
            {
                ChatMessageValues chatMessage = new ChatMessageValues(MessageType.ChatMessageSystem, e.Message);
                ChatHandler.SendMessage(ref session, chatMessage);
            }

            var targetSession = WorldMgr.Sessions.First(o=>o.Value.Character.Guid == target.Guid).Value;
            SpellHandler.HandleLearnedSpells(ref targetSession, new List<uint>(){spellId});           

        }
    }
}
