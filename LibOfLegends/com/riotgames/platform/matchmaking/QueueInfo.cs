using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.matchmaking
{
    public class QueueInfo : AbstractDomainObject
    {
        /** \brief Wait time in queue */
        public int waitTime;
        /** \brief Queue ID */
        public int queueId;
        /** \brief Length of queue */
        public int queueLength;
    }
}
