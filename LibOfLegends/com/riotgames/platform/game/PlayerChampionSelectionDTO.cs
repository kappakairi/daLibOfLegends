using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game
{
    public class PlayerChampionSelectionDTO : AbstractDomainObject
    {
        /** \brief Summoner Internal name of player who selected champ */
        public string summonerInternalName;
        /** \brief Summoner Spell 1 (D) ID */
        public int spell1Id;
        /** \brief Summoner Spell 2 (D) ID */
        public int spell2Id;
        /** \brief Champion selected ID */
        public int championId;
        /** \brief Selected Skin ID */
        public int selectedSkinIndex;
    }
}
