using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game
{
    public class PlatformGameLifecycleDTO : AbstractDomainObject
    {
        /** \brief Reconnect Delay */
        public int reconnectDelay;
        /** \brief Last date modified */
        public double lastModifiedDate;
        /** \brief Game information */
        public GameDTO game;
        /** \brief The player credentials for spectating game */
        public PlayerCredentialsDTO playerCredentials;
        /** \brief Game Name */
        public string gameName;
        /** \brief Connectivity state enum ??? */
        public string connectivityStateEnum;
    }
}
