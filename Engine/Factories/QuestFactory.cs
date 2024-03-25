using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public class QuestFactory
    {
        private static List<Quest> _quest;
        static QuestFactory()
        {
            _quest = new List<Quest>
            {
                new Quest
                {
                    ID = 1,
                    Name = "Quest from the Mayor of Kaps Village",
                    Description =" Slay 3 goblins in the Wicked Forest.",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity {},
                        new ItemQuantity {}
                   
                    },
                    ExpPoints = 100,
                    Gold = 30,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity {}
                    }
                }, new Quest
                {
                    ID = 2,
                    Name = "Quests from Guild Dulenar",
                    Description =" ",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity {},
                        new ItemQuantity {}
                   
                    },
                    ExpPoints = 100,
                    Gold = 30,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity {}
                    }
                }, new Quest
                {
                    ID = 3,
                    Name = "Quest from the Farmer in Haven Village",
                    Description ="Slay goblins and orcs destroying the crops. ",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity {},
                        new ItemQuantity {}
                   
                    },
                    ExpPoints = 100,
                    Gold = 30,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity {}
                    }
                },
            };

        }
         public static Quest GetQuestID (int questID)
        {
            return _quest.Find(q => q.ID == questID);
        }
    }
}
