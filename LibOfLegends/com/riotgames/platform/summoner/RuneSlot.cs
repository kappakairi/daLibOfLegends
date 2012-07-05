using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;
using com.riotgames.platform.catlog.runes;

namespace com.riotgames.platform.summoner
{
    public class RuneSlot : AbstractDomainObject
    {
        public int id;
        public int minLevel;
        public RuneType runeType;
        public Rune rune;
    }
}
