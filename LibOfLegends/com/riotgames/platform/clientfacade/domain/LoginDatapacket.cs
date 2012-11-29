using System;
using System.Collections.Generic;

using FluorineFx.AMF3;

using com.riotgames.platform.statistics;
using com.riotgames.platform.systemstate;
using com.riotgames.platform.game;

#pragma warning disable 0649

using com.riotgames.platform.broadcast;
using com.riotgames.platform.summoner;

namespace com.riotgames.platform.clientfacade.domain
{
	public class LoginDataPacket
	{
		public double rpBalance;
		public double minutesUntilMidnight;
        public string minutesUntilShutdownEnabled;
		public int leaverBusterPenaltyTime;
		//public bool minorShutdownEnforced;
        public string minorShutdownEnforced;
		public bool clientHeartBeatEnabled;
		public PlayerStatSummaries playerStatSummaries;
		public int maxPracticeGameSize;
		public object reconnectInfo;                // TODO check this
		public bool minor;
		public string platformId;
		public string gameTypeConfigs;
		public double ipBalance;
		public string clientSystemStates;
		public SummonerCatalog summonerCatalog;
		public ArrayCollection languages;
		public AllSummonerData allSummonerData;
		public int leaverPenaltyLevel;
		public string broadcastNotification;
		public bool matchMakingEnabled;
		public bool inGhostGame;

        /** \brief Minutes left to earn XP/IP in Custom games */
        public int customMinutesLeftToday;
        /** \brief Minutes left to earn XP/IP in CoOpvsAi games */
        public int coOpVsAiMinutesLeftToday;
        /** \brief Milliseconds until CoOpvsAi limit is reset */
        public double coOpVsAiMsecsUntilReset;
        /** \brief Milliseconds until Custom limit is reset */
        public double customMsecsUntilReset;

        public double timeUntilFirstWinOfDay;

        // TODO look into clientSystemStates and broadcastNotification, LOLNotes shows JSON exists for those
	}
}