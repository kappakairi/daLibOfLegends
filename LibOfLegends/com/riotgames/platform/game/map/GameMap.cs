using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.game.map
{
    public class GameMap : AbstractDomainObject
    {
        /** \brief ID of Map */
        public int mapId;
        /** \brief Map Name */
        public string name;
        /** \brief Map Display Name */
        public string displayName;
        /** \brief Map Description */
        public string description;
        /** \brief Total players on map */
        public int totalPlayers;
        /** \brief Minimum custom players */
        public int minCustomPlayers;
        /** \brief Class type name */
        public string TypeName;

        public GameMap(int id)
        {
            if (id == 1)
            {
                mapId = id;
                name = "SummonersRift";
                displayName = "Summoner's Rift";
                description = "The oldest and most venerated Field of Justice is known as Summoner's Rift.  This battleground is known for the constant conflicts fought between two opposing groups of Summoners.  Traverse down one of three different paths in order to attack your enemy at their weakest point.  Work with your allies to siege the enemy base and destroy their Headquarters!";
                totalPlayers = 10;
                minCustomPlayers = 1;
                TypeName = "com.riotgames.platform.game.map.GameMap";
            }
        }
    }
}
