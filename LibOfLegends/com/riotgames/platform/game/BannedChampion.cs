using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game
{
    public class BannedChampion : AbstractDomainObject
    {
        /** \brief Order of ban, pick turn */
        public int pickTurn;
        /** \brief Banned Champion ID */
        public int championId;
        /** \brief Id of Team (100 = 1, 200 = 2) */
        public int teamId;
    }
}
