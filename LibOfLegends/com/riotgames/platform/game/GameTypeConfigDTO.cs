using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game
{
    public class GameTypeConfigDTO : AbstractDomainObject
    {
        public int id;
        public bool allowTrades;
        public string name;
        public int mainPickTimerDuration;
        public bool exclusivePick;
        public string pickMode;
        public int maxAllowableBans;
        public int banTimerDuration;
        public int postPickTimerDuration;
    }
}
