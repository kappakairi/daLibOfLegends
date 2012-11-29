using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.matchmaking
{
    public class MatchingThrottleConfig : AbstractDomainObject
    {
        public long limit;
        public object[] matchingThrottleProperties;
        public string cacheName;
    }
}
