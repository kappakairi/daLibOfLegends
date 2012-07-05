using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.summoner
{
	public class SummonerDefaultSpells : AbstractDomainObject
	{
		public string summonerDefaultSpellsJson;
		//This is still broken, it doesn't get mapped properly and results in an empty dictionary unless the object type is used
        //Therefore must be retrieved by GETTER method getSummonerDefaultSpells()
		private Dictionary<string, object> summonerDefaultSpellMap;
		public long summonerId;

        public static string classicKey = "CLASSIC";

        private SummonerDefaultSpells()
        {
            summonerDefaultSpellMap = new Dictionary<string,object>();
        }

        private Dictionary<string, SummonerDefaultSpells>  getSummonerDefaultSpells()
        {
            Dictionary<string, SummonerDefaultSpells> tmp = new Dictionary<string, SummonerDefaultSpells>();

            if (summonerDefaultSpellMap.ContainsKey(classicKey))
            {
                tmp[classicKey] = summonerDefaultSpellMap[classicKey] as SummonerDefaultSpells;
            }

            return tmp;
        }
	}
}
