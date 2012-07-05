using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner.masterybook
{
    public class MasteryBook : AbstractDomainObject
    {
        public List<MasteryBookPage> bookPages;
        public string dateString;
        public long summonerId;
    }
}
