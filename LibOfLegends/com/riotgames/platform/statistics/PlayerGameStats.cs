using System;
using System.Collections.Generic;

using com.riotgames.platform.gameclient.domain;

namespace com.riotgames.platform.statistics
{
	public class PlayerGameStats : AbstractDomainObject
	{
        /** \brief Name of champ (unreliable) */
		public string skinName;
        /** \brief Is Ranked game? */       
		public bool ranked;
        /** \brief Skin ID? */                    
		public int skinIndex;
        /** \brief List of players */                
		public List<FellowPlayerInfo> fellowPlayers;  
        /** \brief Type of game */
		public string gameType;
        /** \brief XP earned */               
		public int experienceEarned;
        /** \brief JSON Raw Stats */           
		public string rawStatsJson;
        /** \brief Is First win of day? */           
		public bool eligibleFirstWinOfDay;
        /** \brief Difficulty? */     
		public object difficulty;
        /** \brief ID of Map */            
		public int gameMapId;
        /** \brief Marked as leaver? */  
		public bool leaver;
        /** \brief Summoner Spell D */             
        public int spell1;
        /** \brief Another game Type? Same? */              
		public string gameTypeEnum;
        /** \brief Team ID, values? */            
		public int teamId;
        /** \brief Summoner ID of player */                  
		public int summonerId;
        /** \brief Raw stats like kills, deaths... */        
		public List<RawStat> statistics;
        /** \brief Summoner Spell F */        
		public int spell2;
        /** \brief Marked as AFK? */                
		public bool afk;
        /** \brief Some random ID??? */          
		public int id;
        /** \brief boost XP Earned */             
		public int boostXpEarned;
        /** \brief Summoner Level after game */              
		public int level;
        /** \brief Invalid game? */                  
		public bool invalid;
        /** \brief User ID */               
		public int userId;
        /** \brief Date/Time of game creation */               
		public DateTime createDate;
        /** \brief Ping of user to server */          
		public int userServerPing;
        /** \brief Adjusted Rating (Riot hides this value) */       
		public int adjustedRating;
        /** \brief Size of premade */           
		public int premadeSize;
        /** \brief Boost IP earned */             
		public int boostIpEarned;
        /** \brief Game ID */            
		public int gameId;
        /** \brief Time in Queue in seconds? */                 
		public int timeInQueue;
        /** \brief IP Earned */                
		public int ipEarned;
        /** \brief ELO Change (riot hides this Value) */                  
		public int eloChange;
        /** \brief Game Mode, Dominion or Classic */               
		public string gameMode;
        /** \brief Difficulty STring (useless?) */        
		public string difficultyString;
        /** \brief Think has to do with ELO (riot hides this value) */
		public int KCoefficient;
        /** \brief TEAM Rating based on ELO (riot hides this value) */
		public int teamRating;
        /** \brief SubType of game */
		public string subType;
        /** \brief Queue Type (same as SubType)? */         
		public string queueType;
        /** \brief Premade Team (think it only means full premade, 5 players) */            
		public bool premadeTeam;
        /** \brief predicted outcome based on elo? (Riot hides this value) */          
		public double predictedWinPct;
        /** \brief ELO after game (riot hides this value) */        
		public int rating;
        /** \brief ID of champion used */              
		public int championId;                          
	}
}
