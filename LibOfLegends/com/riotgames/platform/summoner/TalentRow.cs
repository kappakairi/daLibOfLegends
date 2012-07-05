using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
    public class TalentRow : AbstractDomainObject
    {
        public int index;
        public List<Talent> talents;
        public int tltGroupId;
        public int pointsToActivate;
        public int tltRowId;
    }
}
