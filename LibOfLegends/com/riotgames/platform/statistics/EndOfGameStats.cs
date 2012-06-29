using System;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
    public class EndOfGameStats : AbstractDomainObject
    {
        /** \brief Talent Points gained from game? */
        public int talentPointsGained;
        /** \brief True/False Ranked Game? */
        public bool ranked;
        /** \brief Did  */
        public string type;
    }
}