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
        ObjectUpdate                      = 0x17D9,
        TutorialFlags                     = 0x1F35,
        StartCinematic                    = 0x16AD,
        #endregion

        #region JAMClientConnection
        AuthChallenge                     = 0x016A,
        Pong                              = 0x0163,
        #endregion

        #region JAMClientMove
        MoveUpdate                        = 0x139F,
        MoveSetCanFly                     = 0x1353,
        MoveUnsetCanFly                   = 0x16CE,
        MoveSetWalkSpeed                  = 0x0258,
        MoveSetRunSpeed                   = 0x12D6,
        MoveSetSwimSpeed                  = 0x1356,
        MoveSetFlightSpeed                = 0x179F,
        MoveTeleport                      = 0x00A0,
        #endregion

        #region JAMClientQuest
        GossipMessage                     = 0x1508,
        #endregion

        #region JAMClientSpell
        SendKnownSpells                   = 0x1534,
        #endregion

        #region JAMClientDispatch
        QueryGameObjectResponse           = 0x0015,
        DBReply                           = 0x0025,
        UpdateActionButtons               = 0x0096,
        RealmSplit                        = 0x0099,
        LogoutComplete                    = 0x00A8,
        QueryPlayerNameResponse           = 0x00B7,
        AddonInfo                         = 0x0128,
        EnumCharactersResult              = 0x0193,
        NewWorld                          = 0x01AE,
        LoginSetTimeSpeed                 = 0x01AF,
        QueryCreatureResponse             = 0x01B4,
        RealmQueryResponse                = 0x042B,
        DestroyObject                     = 0x04BD,
        UnlearnedSpells                   = 0x0523,
        DeleteChar                        = 0x0806,
        CacheVersion                      = 0x0825,
        MOTD                              = 0x082A,
        LearnedSpells                     = 0x0830,
        QueryNPCTextResponse              = 0x0886,
        AccountDataTimes                  = 0x0890,
        TransferPending                   = 0x08B5,
        GenerateRandomCharacterNameResult = 0x08B9,
        AuthResponse                      = 0x090E,
        UITime                            = 0x0911,
        CreateChar                        = 0x0914,
        UpdateTalentData                  = 0x0924,
        Chat                              = 0x092F,
        #endregion

        TransferInitiate                  = 0x4F57,
    }
}
