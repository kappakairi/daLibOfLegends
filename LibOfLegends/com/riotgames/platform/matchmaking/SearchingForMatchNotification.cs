using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.matchmaking
{
    public class SearchingForMatchNotification : AbstractDomainObject
    {
        /** \brief Player Join Failuers (int ???) */
        public int playerJoinFailures;
        /** \brief GhostGameSummoner (string) */
        public string ghostGameSummoners;
        /** \brief Joined Queues (array) */
        public List<QueueInfo> joinedQueues;
    }
}
