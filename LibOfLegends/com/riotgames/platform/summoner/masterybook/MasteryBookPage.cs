using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner.masterybook
{
    public class MasteryBookPage : AbstractDomainObject
    {
        public List<TalentEntry> talentEntries;
        public long pageId;
        public string name;
        public bool current;
        public DateTime createDate;
        public long summonerId;
    }
}
