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
    public enum ServerMessage : ushort
    {
        #region Legacy
        ObjectUpdate                      = 0x1C89,
        TutorialFlags = 0x0D1B,
        StartCinematic = 0x0198,
        #endregion

        #region JAMClientConnection
        AuthChallenge                     = 0x0C42,
        Pong                              = 0x0C46,
        #endregion

        #region JAMClientMove
        MoveUpdate                        = 0x0EC4,
        MoveSetCanFly = 0x0209,
        MoveUnsetCanFly = 0x031B,
        MoveSetWalkSpeed = 0x0716,
        MoveSetRunSpeed = 0x06A5,
        MoveSetSwimSpeed = 0x0A0D,
        MoveSetFlightSpeed = 0x02B2,
        MoveTeleport = 0x0A2E,
        #endregion

        #region JAMClientGossip
        GossipMessage = 0x03FC,
        #endregion

        #region JAMClientSpell
        SendKnownSpells = 0x1164,
        #endregion

        // Updated
        #region JAMClientDispatch
        UnlearnedSpells                   = 0x0008,
        LoginSetTimeSpeed                 = 0x004A,
        AuthResponse                      = 0x03A8,
        TransferPending                   = 0x0819,
        RealmQueryResponse                = 0x0867,
        QueryNPCTextResponse              = 0x0877,
        AccountDataTimes                  = 0x0899,
        DBReply                           = 0x089A,
        EnumCharactersResult              = 0x08B9,
        MOTD                              = 0x08BB,
        QueryGameObjectResponse           = 0x08F3,
        DeleteChar                        = 0x0A1E,
        CacheVersion                      = 0x0A4C,
        Chat                              = 0x0A5B,
        DestroyObject                     = 0x0A75,
        UpdateTalentData                  = 0x0A79,
        AddonInfo                         = 0x0A9C,
        NewWorld                          = 0x0ABF,
        LogoutComplete                    = 0x0C6D,
        LearnedSpells                     = 0x0C6E,
        GenerateRandomCharacterNameResult = 0x0D24,
        UpdateActionButtons               = 0x0E2C,
        QueryPlayerNameResponse           = 0x0E48,
        QueryCreatureResponse             = 0x0E85,
        CreateChar                        = 0x0FAD,
        UITime                            = 0x12C6,
        #endregion

        TransferInitiate                  = 0x4F57,
    }
}
