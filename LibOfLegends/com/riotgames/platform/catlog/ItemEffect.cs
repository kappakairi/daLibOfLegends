using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.catlog
{
    public class ItemEffect : AbstractDomainObject
    {
        public int effectId;
        public int itemEffectId;
        public Effect effect;
        public double value;
        public int itemId;
    }
}
