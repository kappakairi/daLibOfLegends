using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
    public class TalentGroup : AbstractDomainObject
    {
        public int index;
        public List<TalentRow> talentRows;
        public string name;
        public int tltGroupId;
    }
}
