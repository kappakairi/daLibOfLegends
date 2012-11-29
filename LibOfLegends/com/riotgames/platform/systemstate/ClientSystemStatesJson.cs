using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace com.riotgames.platform.systemstate
{
    public class ClientSystemStatesJson
    {
        public bool practiceGameEnabled;
        public bool advancedTutorialEnabled;
        public int minNumPlayersForPracticeGame;
        public List<int> practiceGameTypeConfigIdList;
        public List<int> freeToPlayChampionIdList;
        public List<int> inactiveChampionIdList;
        public List<int> inactiveSpellIdList;
        public List<int> inactiveTutorialSpellIdList;
        public List<int> inactiveClassicSpellIdList;
        public List<int> inactiveOdinSpellIdList;
        public List<int> inactiveAramSpellIdList;
        public List<int> enabledQueueIdsList;
        public List<int> unobtainableChampionSkinIDList;
        public bool archivedStatsEnabled;
        public string queueThrottleDTO;
        public QueueThrottleDTO mode;
        public List<GameMapEnabledDTO> gameMapEnabledDTOList;
        public bool storeCustomerEnabled;
        public bool socialIntegrationEnabled;
        public bool runeUniquePerSpellBook;
        public bool tribunalEnabled;
        public bool observerModeEnabled;
        public int spectatorSlotLimit;
        public int clientHeartBeatRateSeconds;
        public List<string> observableGameModes;
        public List<string> observableCustomGameModes;
        public bool teamServiceEnabled;
        public bool modularGameModeEnabled;
        public double riotDataServiceDataSendProbability;
        public bool displayPromoGamesPlayedEnabled;
        public bool masteryPageOnServer;
        public int maxMasteryPagesOnServer;
        public bool tournamentSendStatsEnabled;
        public bool kudosEnabled;

    }
}
