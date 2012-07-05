using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;
using com.riotgames.platform.catlog.runes;

namespace com.riotgames.platform.catlog
{
    public class Effect : AbstractDomainObject
    {
        public int effectId;
        public string gameCode;
        public string name;
        /** \brief Category ID (type unknown) */
        public object categoryId;
        public RuneType runeType;
    }
}
