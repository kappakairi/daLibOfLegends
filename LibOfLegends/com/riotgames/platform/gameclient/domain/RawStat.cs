namespace com.riotgames.platform.gameclient.domain
{
    /**
     * RawStat is a class that shows a specific raw stat from a game (kills, assists, gold earned...).
     * It is usually in a List format which includes all the raw stats from the game, and specific stat
     * is identified by "statType".
     */
	public class RawStat
	{
                                        /** Name of statistic displayed */
        public string displayName;      /** The type of statistic identified by a key 
                                         * 
                                         * Possilbe Keys for Stat Types:
                                         *   - CHAMPIONS_KILLED
                                         *   - NUM_DEATHS
                                         *   - ASSISTS
                                         *   - LOSE
                                         *   - LEVEL
                                         *   - MINIONS_KILLED
                                         *   - NEURTAL_MINIONS_KILLED
                                         *   - TURRETS_KILLED
                                         *   - GOLD_EARNED
                                         *   - MAGIC_DAMAGE_DEALT_PLAYER
                                         *   - PHYSICAL_DAMAGE_DEALT_PLAYER
                                         *   - TOTAL_DAMAGE_DEALT
                                         *   - MAGICAL_DAMAGE_TAKEN
                                         *   - PHYSICAL_DAMAGE_TAKEN
                                         *   - TOTAL_DAMAGE_TAKEN
                                         *   - TOTAL_HEAL
                                         *   - LARGEST_MULTI_KILL
                                         *   - LARGEST_KILLING_SPREE
                                         *   - TOTAL_TIME_SPENT_DEAD
                                         *   - ITEM0
                                         *   - ITEM1
                                         *   - ITEM2
                                         *   - ITEM3
                                         *   - ITEM4
                                         *   - ITEM5
                                         */
        public string statType;         /** Value of statistic */
        public int value;
	}
}
