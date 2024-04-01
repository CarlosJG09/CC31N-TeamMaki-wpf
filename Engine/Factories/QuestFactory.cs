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
                    Description =" Slay 3 Goblins in the Wicked Forest.",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity {},
                        new ItemQuantity {}
                   
                    },
                    ExpPoints = 100,
                    Gold = 30,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity {ItemID = 103, Quantity = 1},
                        new ItemQuantity {ItemID = 1001, Quantity = 1}

                    }
                }, 
                new Quest
                {
                    ID = 2,
                    Name = "Quests from Guild Dulenar",
                    Description =" Slay 5 Goblins and 5 Ghouls",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity {},
                        new ItemQuantity {}
                   
                    },
                    ExpPoints = 100,
                    Gold = 50,
                    RewardItems = new List<ItemQuantity>
                    {
                         new ItemQuantity {ItemID = 102, Quantity = 1},
                        new ItemQuantity {ItemID = 1002, Quantity = 1}                     
                    }
                    
                },  new Quest
                {
                    ID = 3,
                    Name = "Quests from Guild Dulenar 2",
                    Description ="Slay 2 Giants and 2 Witches ",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity {},
                        new ItemQuantity {}
                   
                    },
                    ExpPoints = 100,
                    Gold = 80,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity { ItemID = 105, Quantity =1},
                        new ItemQuantity { ItemID = 1003, Quantity =1},

                    }
                    
                }, 
                new Quest
                {
                    ID = 4,
                    Name = "Quest from the Farmer in Haven Village",
                    Description ="Slay goblins and orcs destroying the crops. ",
                    ItemsToComplete = new List<ItemQuantity>
                    {
                        new ItemQuantity {},
                        new ItemQuantity {}
                   
                    },
                    ExpPoints = 100,
                    Gold = 80,
                    RewardItems = new List<ItemQuantity>
                    {
                        new ItemQuantity {ItemID = 101, Quantity = 1},
                        new ItemQuantity {ItemID = 1004, Quantity = 1},
                    }
                },
            };

        }
         public static Quest GetQuestID (int questID)
        {
            return _quest.Find(qi => qi.ID == questID);
        }
    }
}
