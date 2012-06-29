using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.matchmaking
{
    public class MatchMakerParams : AbstractDomainObject
    {
        /** \brief Team ID */
        public int teamId;
        /** \brief bot Difficulty */
        public string botDifficulty;
        /** \brief invitation Id */
        public int invitationId;
        /** \brief team (string???) */
        public string team;
        /** \brief Last MaestroMessage */
        public string lastMaestroMessage;
        /** \brief Languages */
        public string languages;
    }
}
