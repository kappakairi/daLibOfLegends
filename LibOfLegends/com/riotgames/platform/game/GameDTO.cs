using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game
{
    public class GameDTO : AbstractDomainObject
    {
        /** \brief ID of Game */
        public long id;
        /** \brief Game name */
        public string name;
        /** \brief Chat Room Name */
        public string roomName;
        /** \brief Is there a password? */
        public bool passwordSet;
        /** \brief Spectators Allowed Setting */
        public string spectatorsAllowed;
        /** \brief Spectator Delay */
        public int spectatorDelay;
        /** \brief Game Type */
        public string gameType;
        /** \brief Game type config ID */
        public int gameTypeConfigId;
        /** \brief Current State of game, (TEAM_SELECT, CHAMP_SELECT), etc.. */
        public string gameState;
        /** \brief Game Mode (CLASSIC, DOMINION) */
        public string gameMode;
        /** \brief Map ID */
        public int mapId;
        /** \brief Maximum number of players allowed */
        public int maxNumPlayers;
        /** \brief Expiration time of lobby */
        public double expiryTime;
        /** \brief Name of queue type */
        public string queueTypeName;
        /** Position in queue */
        public int queuePosition;
        /** \brief Pick turn for champ select */
        public int pickTurn;
        /** \brief Summary of game owner/creator (PlayerParticipant) */
        public PlayerParticipant ownerSummary;
        /** \brief List of Players (PlayerParticipant) on Team One (A) */
        public List<PlayerParticipant> teamOne;
        /** \brief List of Players (PlayerParticipant) on Team Two (B) */
        public List<PlayerParticipant> teamTwo;
        /** \brief List of Players and the champs they selected */
        public List<PlayerChampionSelectionDTO> playerChampionSelections;
        /** \brief List of Observers */
        public List<GameObserver> observers;
        /** \brief Ban order (team number array) */
        public List<int> banOrder;
        /** \brief List of Banned Champions */
        public List<BannedChampion> bannedChampions;
        /** \brief Optimistic lock ??? */
        public double optimisticLock;
    }
}
