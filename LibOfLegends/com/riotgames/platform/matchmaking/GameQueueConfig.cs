using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.matchmaking
{
    public class GameQueueConfig : AbstractDomainObject
    {
        public int blockedMinutesThreshold;
        public int minimumParticipantListSize;
        public bool ranked;
        public int maxLevel;
        public int minLevel;
        public int gameTypeConfigId;
        public bool thresholdEnabled;
        public string queueState;
        public string type;
        public string cacheName;
        public int id;
        public string queueBonusKey;
        public string queueStateString;
        public string pointsConfigKey;
        public bool teamOnly;
        public long minimumQueueDodgeDelayTime;
        public List<int> supportedMapIds;
        public string gameMode;
        public string typeString;
        public int numPlayersPerTeam;
        public int maximumParticipantListSize;
        public bool disallowFreeChampions;
        public long thresholdSize;
        public MatchingThrottleConfig matchingThrottleConfig;
    }
}
