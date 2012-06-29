using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;
using com.riotgames.platform.game.map;

namespace com.riotgames.platform.game
{
    public class PracticeGameConfig : AbstractDomainObject
    {
        /** \brief Name of Game */
        public string gameName;
        /** \brief Password for Game */
        public string gamePassword;
        /** \brief Passback URL (usually null) */
        public string passbackUrl;
        /** \brief Data Packet for passback (usually null) */
        public string passbackDataPacket;
        /** \brief Spectator setting (All, friends, etc) */
        public string allowSpectators;
        /** \brief Type of Game Config */
        public int gameTypeConfig;
        /** \brief Game mode (Classic, dominion) */
        public string gameMode;
        /** \brief Maximum allowed players */
        public int maxNumPlayers;
        /** \brief Class type name */
        public string TypeName;
        /** \brief Game Map and configuration */
        public GameMap gameMap;

        public PracticeGameConfig(string gName, string gPass)
        {
            gameName = gName;
            gamePassword = gPass;
            passbackUrl = null;
            passbackDataPacket = null;
            allowSpectators = "ALL";
            gameTypeConfig = 1;
            gameMode = "CLASSIC";
            maxNumPlayers = 10;
            TypeName = "com.riotgames.platform.game.PracticeGameConfig";
            gameMap = new GameMap(1);
        }
    }
}
