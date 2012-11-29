using System;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
	public class PlayerLifeTimeStats : AbstractDomainObject
	{
		public PlayerStatSummaries playerStatSummaries;
		public LeaverPenaltyStats leaverPenaltyStats;
		public DateTime previousFirstWinOfDay;
		public int userId;
		public int dodgeStreak;
		//Can be null so it must not have the right type right away, otherwise it will get converted to a bogus date
		//public DateTime dodgePenaltyDate;
		public object dodgePenaltyDate;
		public string playerStatsJson;
		public PlayerStats playerStats;

        public PlayerStatSummary getRankedSolo5x5()
        {

            for (int i = 0; i < playerStatSummaries.playerStatSummarySet.Count; i++)
            {
                if (playerStatSummaries.playerStatSummarySet[i].playerStatSummaryTypeString.ToLower() == "rankedsolo5x5")
                {
                    return playerStatSummaries.playerStatSummarySet[i];
                }
            }

            return null;
        }

        public PlayerStatSummary getNormal5x5()
        {

            for (int i = 0; i < playerStatSummaries.playerStatSummarySet.Count; i++)
            {
                if (playerStatSummaries.playerStatSummarySet[i].playerStatSummaryTypeString.ToLower() == "unranked")
                {
                    return playerStatSummaries.playerStatSummarySet[i];
                }
            }

            return null;
        }

        public PlayerStatSummary getRankedTeam5x5()
        {

            for (int i = 0; i < playerStatSummaries.playerStatSummarySet.Count; i++)
            {
                if (playerStatSummaries.playerStatSummarySet[i].playerStatSummaryTypeString.ToLower() == "rankedteam5x5")
                {
                    return playerStatSummaries.playerStatSummarySet[i];
                }
            }

            return null;
        }

        public int getRankedKills()
        {
            PlayerStatSummary rTeam5x5 = getRankedTeam5x5();
            PlayerStatSummary rSolo5x5 = getRankedSolo5x5();
            int value = 0;

            if (rTeam5x5 != null)
                value += rTeam5x5.aggregatedStats.getKills();

            if (rSolo5x5 != null)
                value += rSolo5x5.aggregatedStats.getKills();

            return value;
        }

        public int getRankedAssists()
        {
            PlayerStatSummary rTeam5x5 = getRankedTeam5x5();
            PlayerStatSummary rSolo5x5 = getRankedSolo5x5();
            int value = 0;

            if (rTeam5x5 != null)
                value += rTeam5x5.aggregatedStats.getAssists();

            if (rSolo5x5 != null)
                value += rSolo5x5.aggregatedStats.getAssists();

            return value;
        }

        public int getRankedTurretKills()
        {
            PlayerStatSummary rTeam5x5 = getRankedTeam5x5();
            PlayerStatSummary rSolo5x5 = getRankedSolo5x5();
            int value = 0;

            if (rTeam5x5 != null)
                value += rTeam5x5.aggregatedStats.getTurretKills();

            if (rSolo5x5 != null)
                value += rSolo5x5.aggregatedStats.getTurretKills();

            return value;
        }

        public int getRankedMinionKills()
        {
            PlayerStatSummary rTeam5x5 = getRankedTeam5x5();
            PlayerStatSummary rSolo5x5 = getRankedSolo5x5();
            int value = 0;

            if (rTeam5x5 != null)
                value += (rTeam5x5.aggregatedStats.getMinionKills() + rTeam5x5.aggregatedStats.getNeutralMinionKills());

            if (rSolo5x5 != null)
                value += (rSolo5x5.aggregatedStats.getMinionKills() + rSolo5x5.aggregatedStats.getNeutralMinionKills());

            return value;
        }
	}
}