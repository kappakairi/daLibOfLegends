using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game
{
    public class GameObserver : AbstractDomainObject
    {
        /** \brief Account ID of observer */
        public long accountId;
        /** \brief Summoner ID of observer */
        public long summonerId;
        /** \brief Summoner Name of observer */
        public string summonerName;
        /** \brief Summoner Internal Name */
        public string summonerInternalName;
        /** \brief Pick turn? */
        public int pickTurn;
        /** \brief Profile Icon ID of observer */
        public int profileIconId;
        /** \brief Last selected skin index */
        public int lastSelectedSkinIndex;
    }
}
