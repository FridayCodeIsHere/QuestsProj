using System;
using System.Collections.Generic;

namespace Builder
{
    public class Program
    {
        static void Main(string[] args)
        {
            PlayerData player = new PlayerData();

            foreach(KeyValuePair<EQuestId, CQuestConfig> questConfig in player.Quests.QuestsData)
            {
                Console.WriteLine($"{questConfig.Key} Quests:");
                

                CQuest[] quests = questConfig.Value.Quests.ToArray();
                for(int i = 0; i < quests.Length; i++)
                {
                    
                    Console.Write($"{i + 1}. {quests[i].Description} \t <{quests[i].DoneTasksCount}/{quests[i].MaxTasksCount}> \t");
                    foreach(CCurrency reward in quests[i].Rewards)
                    {
                        Console.Write($"[{reward.Id}: {reward.Value}] \t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
