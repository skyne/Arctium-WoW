/*
 * Copyright (C) 2012-2013 Arctium <http://arctium.org>
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

namespace Framework.Constants.NetMessage
{
    public enum ClientMessage : ushort
    {
        #region ChatMessages
        ChatMessageSay               = 0x10BE,
        ChatMessageYell              = 0x1015,
        ChatMessageWhisper           = 0x19B6,
        #endregion

        #region UserRouterClient
        AuthSession                  = 0x0790,
        Ping                         = 0x0784,
        LogDisconnect                = 0x0380,
        #endregion

        #region Legacy
        ActivePlayer                 = 0x171B,
        #endregion

        // Value > 0x1FFF are not known.
        #region JAM
        ObjectUpdateFailed          = 0x1926,
        ViolenceLevel               = 0x1927,
        RealmSplit                  = 0x129F,
        DBQueryBulk                 = 0x1A8B,
        GenerateRandomCharacterName = 0x164B,
        EnumCharacters              = 0x1B9E,
        PlayerLogin                 = 0x1BC7,
        LoadingScreenNotify         = 0x160B,
        SetActionButton             = 0x129E,
        CreateCharacter             = 0x17CF,
        QueryPlayerName             = 0x16DB,
        QueryRealmName              = 0x13D7,
        ReadyForAccountDataTimes    = 0x1A0E,
        UITimeRequest               = 0x1646,
        CharDelete                  = 0x1783,
        CliSetSpecialization                       = 0x005B,
        CliLearnTalents                            = 0x044B,
        CliQueryCreature            = 0x1585,
        CliQueryGameObject          = 0x15A4,
        CliQueryNPCText             = 0x108B,
        CliTalkToGossip             = 0x1414,
        CliLogoutRequest            = 0x16E7,
        CliSetSelection             = 0x1B76,
        #endregion

        #region PlayerMove
        MoveStartForward            = 0x0723,
        MoveStartBackward           = 0x0216,
        MoveStop                    = 0x0A06,
        MoveStartStrafeLeft         = 0x0312,
        MoveStartStrafeRight        = 0x0722,
        MoveStopStrafe              = 0x0E0F,
        MoveJump                    = 0x0B17,
        MoveStartTurnLeft           = 0x0A22,
        MoveStartTurnRight          = 0x020E,
        MoveStopTurn                = 0x060A,
        MoveStartPitchUp            = 0x0E0E,
        MoveStartPitchDown          = 0x063A,
        MoveStopPitch               = 0x0A1B,
        MoveSetRunMode              = 0x0A37,
        MoveSetWalkMode             = 0x0A3E,
        MoveFallLand                = 0x031F,
        MoveStartSwim               = 0x0712,
        MoveStopSwim                = 0x0A1F,
        MoveToggleCollisionCheat    = 0x030A,
        MoveSetFacing               = 0x0B3A,
        MoveSetPitch                               = 0x0717,
        MoveHeartbeat               = 0x0717,
        MoveFallReset                              = 0x0AC3,
        MoveSetFly                  = 0x063E,
        MoveStartAscend             = 0x061F,
        MoveStopAscend              = 0x0A2F,
        MoveChangeTransport                        = 0x0C92,
        MoveStartDescend            = 0x033A,
        MoveDismissVehicle          = 0x072A,
        #endregion

        TransferInitiate            = 0x4F57,
    }
}
