using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner.masterybook
{
    public class TalentEntry : AbstractDomainObject
    {
        public int rank;
        public int talentId;
        public Talent talent;
        /** \brief Summoner ID (seems to always be -1) */
        public long summonerId;
    }
}
