using System;

using FluorineFx.AMF3;

using com.riotgames.platform.statistics;
using com.riotgames.platform.systemstate;

#pragma warning disable 0649

namespace com.riotgames.platform.clientfacade.domain
{
	class LoginDataPacket
	{
		public double rpBalance;
		public double minutesUntilMidnight;
		public int leaverBusterPenaltyTime;
		public bool minorShutdownEnforced;
		public bool clientHeartBeatEnabled;
		public PlayerStatSummaries playerStatSummaries;
		public int maxPracticeGameSize;
		public object reconnectInfo;                // TODO check this
		public bool minor;
		public string platformId;
		public ArrayCollection gameTypeConfigs;        // TODO fix this
		public double ipBalance;
		public ClientSystemStatesNotification clientSystemStates;
		public object summonerCatalog;                    // TODO fix this
		public ArrayCollection languages;
		public object allSummonerData;
		public int leaverPenaltyLevel;
		public object broadcastNotification;
		public bool matchMakingEnabled;
		public bool inGhostGame;

        /** \brief Minutes left to earn XP/IP in Custom games */
        public int customMinutesLeftToday;
        /** \brief Minutes left to earn XP/IP in CoOpvsAi games */
        public int coOpVsAiMinutesLeftToday;
        /** \brief Milliseconds until CoOpvsAi limit is reset */
        public long coOpVsAiMsecsUntilReset;
        /** \brief Milliseconds until Custom limit is reset */
        public long customMsecsUntilReset;

        // TODO look into clientSystemStates and broadcastNotification, LOLNotes shows JSON exists for those
	}
}