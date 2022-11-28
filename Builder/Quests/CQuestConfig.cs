using System;
using System.Collections.Generic;

namespace Builder
{
    public class CQuestConfig
    {
        private readonly List<CQuest> quests = new List<CQuest>();
        public List<CQuest> Quests => this.quests;

        public void AddQuest(string description, int maxCountTasks, params CCurrency[] rewards)
        {
            this.quests.Add(new CQuest(description, maxCountTasks, rewards));
        }
    }
}
