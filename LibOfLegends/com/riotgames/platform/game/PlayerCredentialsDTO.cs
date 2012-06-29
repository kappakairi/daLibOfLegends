using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game
{
    public class PlayerCredentialsDTO : AbstractDomainObject
    {
        /** \brief Encryption key */
        public string encryptionKey;
        /** \brief Game ID */
        public long gameId;
        /** \brief Game Server IP */
        public string serverIp;
        /** \brief Is there observers? ??? */
        public bool observer;
        /** \brief Observer Server IP */
        public string observerServerIp;
        /** \brief HandshakeToken ??? */
        public string handshakeToken;
        /** \brief Player ID (of observer???) */
        public long playerId;
        /** \brief Game Server Port */
        public int serverPort;
        /** \brief Observer Server Port */
        public int observerServerPort;
        /** \brief Summoner name (of observer???) */
        public string summonerName;
        /** \brief Observer Encryption Key */
        public string observerEncryptionKey;
    }
}
