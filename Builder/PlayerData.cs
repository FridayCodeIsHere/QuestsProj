using System.Collections.Generic;

namespace Builder
{
    public class PlayerData
    {
        public Bank Bank { get; private set; }
        public CQuests Quests { get; private set; }

        public PlayerData()
        {
            this.Bank = new Bank();
            this.Quests = new CQuests();
        }
    }
}
