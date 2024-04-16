using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    internal static  class QuestFactory
    {
        private static List<Quest> _quest = new List<Quest>();
        static QuestFactory()
        {
            List<ItemQuantity> itemsToComplete = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems = new List<ItemQuantity>();

            itemsToComplete.Add(new ItemQuantity(201, 2));
            rewardItems.Add(new ItemQuantity(1004, 1));

            _quest.Add (new Quest(1 ,
                                  "Quest from the Mayor of Kaps Village",
                                  "Slay 3 Goblins in the Wicked Forest",
                                  itemsToComplete,
                                  50, 30,
                                  rewardItems));

            List<ItemQuantity> itemsToComplete1 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems1 = new List<ItemQuantity>();

            itemsToComplete1.Add(new ItemQuantity (202, 2));
            rewardItems1.Add(new ItemQuantity (105, 1));


            _quest.Add(new Quest(2,
                                 "Quest from the Merchant",
                                 "Slay 5 ghouls in Shadow Forest ",
                                 itemsToComplete,
                                 100, 30,
                                 rewardItems));

            List<ItemQuantity> itemsToComplete2 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems2 = new List<ItemQuantity>();

            itemsToComplete2.Add(new ItemQuantity(204, 2));
            rewardItems2.Add(new ItemQuantity(102, 2));
            _quest.Add(new Quest(3,
                                 "Quest from Merchant",
                                 "Slay 5 Orcs in MarshLands",
                                 itemsToComplete,
                                 150, 50,
                                 rewardItems));

            List<ItemQuantity> itemsToComplete3 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems3 = new List<ItemQuantity>();

            itemsToComplete3.Add(new ItemQuantity(203, 2));
            rewardItems3.Add(new ItemQuantity(103, 1));

            _quest.Add(new Quest(4,
                                 "Quest from Wanderer",
                                 "Slay 3 Witches Elder Peaks",
                                 itemsToComplete,
                                 125, 35,
                                 rewardItems));

            List<ItemQuantity> itemsToComplete4 = new List<ItemQuantity>();
            List<ItemQuantity> rewardItems4 = new List<ItemQuantity>();

            itemsToComplete4.Add(new ItemQuantity(205, 1));
            rewardItems4.Add(new ItemQuantity(1003, 1));
            _quest.Add(new Quest(5,
                                 "Quest from farmer",
                                 "Slay 2 Giants in CropFarm",
                                 itemsToComplete,
                                 200, 50,
                                 rewardItems));
        }

         public static Quest GetQuestID (int id)
        {
            return _quest.FirstOrDefault(quest => quest.ID == id);
        }
    }
}
