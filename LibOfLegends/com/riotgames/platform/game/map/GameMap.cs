using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game.map
{
    public class GameMap : AbstractDomainObject
    {
        /** \brief ID of Map */
        public int mapId;
        /** \brief Map Name */
        public string name;
        /** \brief Map Display Name */
        public string displayName;
        /** \brief Map Description */
        public string description;
        /** \brief Total players on map */
        public int totalPlayers;
        /** \brief Minimum custom players */
        public int minCustomPlayers;
        /** \brief Class type name */
        public string TypeName;
    }
}
