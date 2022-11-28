using System.Collections.Generic;

namespace Builder
{
    public class CQuests
    {
        private readonly Dictionary<EQuestId, CQuestConfig> quests = new Dictionary<EQuestId, CQuestConfig>();
        public Dictionary<EQuestId, CQuestConfig> QuestsData => this.quests;

        public CQuests()
        {
            this.Init();
            this.CompleteDailyQuests();
            this.CompleteWeeklyQuests();
        }

        private void Init()
        {
            this.quests.Add(EQuestId.Daily, new CQuestConfig());
            this.quests.Add(EQuestId.Weekly, new CQuestConfig());
            this.quests.Add(EQuestId.Monthly, new CQuestConfig());
            this.quests.Add(EQuestId.Special, new CQuestConfig());
        }

        private void CompleteDailyQuests()
        {

            this.quests[EQuestId.Daily].AddQuest("Find 5 branches", 5, new CCurrency(ECurrencyId.Gold, 20), new CCurrency(ECurrencyId.Xp, 50));
            this.quests[EQuestId.Daily].AddQuest("Win 3 fights", 3, new CCurrency(ECurrencyId.Diamand, 2), new CCurrency(ECurrencyId.Xp, 70));
        }

        private void CompleteWeeklyQuests()
        {
            this.quests[EQuestId.Weekly].AddQuest("Find 50 branches", 50, new CCurrency(ECurrencyId.Diamand, 20), new CCurrency(ECurrencyId.Gold, 300));
            this.quests[EQuestId.Weekly].AddQuest("Win 30 fights", 30, new CCurrency(ECurrencyId.Gold, 100), new CCurrency(ECurrencyId.Gold, 350));
            this.quests[EQuestId.Weekly].AddQuest("Get 25 rewards", 25, new CCurrency(ECurrencyId.Xp, 140), new CCurrency(ECurrencyId.Gold, 200));
        }

        public CQuestConfig GetQuests(EQuestId questId)
        {
            return this.quests[questId];
        }


    }
}
