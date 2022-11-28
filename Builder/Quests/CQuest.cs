using System;
using Builder;

namespace Builder
{
    public class CQuest
    {
        public string Description;
        public int DoneTasksCount { get; private set; }
        public int MaxTasksCount { get; private set; }
        public CCurrency[] Rewards { get; }

        public bool Claimed { get; private set; }
        public bool Done;

        public CQuest(string description, int maxTasksCount, CCurrency[] rewards)
        {
            this.Description = description;
            this.Rewards = rewards;
            this.MaxTasksCount = maxTasksCount;
        }

        public void SetDoneTaskCount(int countDoneTasks)
        {
            this.DoneTasksCount = countDoneTasks;
        }

        public void Claim()
        {
            this.Claimed = true;
        }
    }
}
