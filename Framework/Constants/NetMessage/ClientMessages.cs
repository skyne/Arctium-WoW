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
        ChatMessageSay                             = 0x016A,
        ChatMessageYell                            = 0x1333,
        ChatMessageWhisper                         = 0x143A,
        #endregion

        #region UserRouterClient
        AuthSession                                = 0x09F1,
        Ping                                       = 0x08E3,
        LogDisconnect                              = 0x09A2,
        #endregion

        #region Legacy
        ActivePlayer                               = 0x0704,
        #endregion

        // Value > 0x1FFF are not known.
        #region JAM
        ObjectUpdateFailed          = 0x1926,
        ViolenceLevel                              = 0x054B,
        RealmSplit                  = 0x129F,
        DBQueryBulk                                = 0x0149,
        GenerateRandomCharacterName = 0x164B,
        EnumCharacters              = 0x1B9E,
        PlayerLogin                 = 0x1BC7,
        LoadingScreenNotify         = 0x160B,
        SetActionButton                            = 0x0C08,
        CreateCharacter             = 0x17CF,
        QueryPlayerName                            = 0x0018,
        QueryRealmName                             = 0x0209,
        ReadyForAccountDataTimes    = 0x1A0E,
        UITimeRequest                              = 0x0405,
        CharDelete                  = 0x1783,
        CliSetSpecialization                       = 0x005B,
        CliLearnTalents                            = 0x044B,
        CliQueryCreature                           = 0x050F,
        CliQueryGameObject                         = 0x058F,
        CliQueryNPCText                            = 0x009E,
        CliTalkToGossip                            = 0x1414,
        CliLogoutRequest            = 0x1323,
        CliSetSelection                            = 0x1759,
        #endregion

        #region PlayerMove
        MoveStartForward            = 0x0723,
        MoveStartBackward           = 0x0216,
        MoveStop                    = 0x0A06,
        MoveStartStrafeLeft         = 0x0312,
        MoveStartStrafeRight                       = 0x0843,
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
        MoveFallLand                               = 0x0CCF,
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
