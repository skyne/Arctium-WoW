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
        ChatMessageSay = 0x14FC,
        ChatMessageYell = 0x045C,
        ChatMessageWhisper = 0x14D8,
        #endregion

        #region UserRouterClient
        AuthSession                 = 0x196E, // done
        Ping                        = 0x18E2, // done
        LogDisconnect               = 0x19EA,
        #endregion

        #region Legacy
        ActivePlayer                = 0x0A12,
        #endregion

        // Value > 0x1FFF are not known.
        #region JAM
        ObjectUpdateFailed = 0x1A44,
        ViolenceLevel               = 0x0448, // done
        DBQueryBulk                 = 0x0676, // done
        GenerateRandomCharacterName = 0x0DD1, // done
        EnumCharacters              = 0x047C, // done
        PlayerLogin                 = 0x0754, // done
        LoadingScreenNotify         = 0x0650, // done
        SetActionButton = 0x014C,
        CreateCharacter             = 0x077B, // done
        QueryPlayerName = 0x11E9,
        QueryRealmName = 0x09E1,
        ReadyForAccountDataTimes    = 0x047F, // done
        UITimeRequest               = 0x0574, // done
        CharDelete                  = 0x067A, // done
        CliSetSpecialization = 0x17DF,
        CliLearnTalents = 0x1776,
        CliQueryCreature = 0x1647,
        CliQueryGameObject = 0x1677,
        CliQueryNPCText = 0x17CF,
        CliTalkToGossip = 0x025C,
        CliLogoutRequest = 0x03EC,
        CliSetSelection = 0x07CD,
        #endregion

        #region PlayerMove
        MoveStartForward         = 0x112B,
        MoveStartBackward        = 0x02B6,
        MoveStop                 = 0x0609,
        MoveStartStrafeLeft      = 0x0626,
        MoveStartStrafeRight     = 0x048A,
        MoveStopStrafe           = 0x027C,
        MoveJump                 = 0x042F,
        MoveStartTurnLeft        = 0x0409,
        MoveStartTurnRight       = 0x04A0,
        MoveStopTurn             = 0x0488,
        MoveStartPitchUp         = 0x00B6,
        MoveStartPitchDown       = 0x062B,
        MoveStopPitch            = 0x00F5,
        MoveSetRunMode           = 0x0426,
        MoveSetWalkMode          = 0x0625,
        MoveFallLand             = 0x00BC,
        MoveStartSwim            = 0x007E,
        MoveStopSwim             = 0x027F,
        MoveToggleCollisionCheat = 0x0037,
        MoveSetFacing            = 0x04AF,
        MoveSetPitch             = 0x0689,
        MoveHeartbeat            = 0x04AD,
        MoveFallReset            = 0x007F,
        MoveSetFly               = 0x060C,
        MoveStartAscend          = 0x0688,
        MoveStopAscend           = 0x06AA,
        MoveChangeTransport      = 0x040F,
        MoveStartDescend         = 0x062A,
        MoveDismissVehicle       = 0x0428,
        #endregion

        TransferInitiate = 0x4F57,
    }
}
