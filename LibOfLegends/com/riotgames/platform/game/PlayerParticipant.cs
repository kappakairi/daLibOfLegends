using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game
{
    public class PlayerParticipant : AbstractDomainObject
    {
        /** \brief Account ID of player */
        public long accountId;
        /** \brief Summoner ID of player */
        public long summonerId;
        /** \brief Summoner Name of player */
        public string summonerName;
        /** \brief Summoner Internal Name */
        public string summonerInternalName;
        /** \brief Date of birth of player ROFL */
        public DateTime dateOfBirth;
        /** \brief Time Added to the queue */
        public double timeAddedToQueue;
        /** \brief Queue Rating (ELO) */
        public int queueRating;
        /** \brief Index ??? */
        public long index;
        /** \brief Bot Difficulty */
        public string botDifficulty;
        /** \brief Last selected skin (id) */
        public int lastSelectedSkinIndex;
        /** \brief Profile Icon ID of player */
        public int profileIconId;
        /** \brief Pick turn of player? */
        public int pickTurn;
        /** \brief Pick mode */
        public int pickMode;
        /** \brief Is player team owner? */
        public bool teamOwner;
        /** \brief Team participant id (ranked teams?) */
        public long teamParticipantId;
        /** \brief Client in sync boolean */
        public bool clientInSynch;
    }
}
