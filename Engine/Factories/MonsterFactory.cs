using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public static class MonsterFactory
    {
        public static Monster GetMonster(int monsterID)
        {
            switch (monsterID)
            {
                case 1:
                    Monster goblin =
                        new Monster("Goblin", "goblin.png",
                                    4, 4, 3, 2, 10, 3);
                    AddLootItem(goblin, 201, 70);
                    AddLootItem(goblin, 101, 40);

                    return goblin;

                case 2:
                    Monster ghoul =
                        new Monster("Ghoul", "ghoul.png",
                        6, 6, 2, 5, 15, 5);
                    AddLootItem(ghoul, 202, 75);
                    AddLootItem(ghoul, 101, 40);
                    AddLootItem(ghoul, 1004, 40);
                    return ghoul;

                case 3:
                    Monster witches =
                        new Monster("Witch", "witches.png",
                        6, 6, 2, 5, 18, 5);
                    AddLootItem(witches, 203, 75);
                    AddLootItem(witches, 1004, 40);
                    AddLootItem(witches, 102, 10);
                  
                    return witches;

                case 4:
                    Monster orc =
                        new Monster("Orc", "orc.png", 
                        7, 7, 2, 5, 20, 5);
                    AddLootItem(orc, 204, 75);
                    AddLootItem(orc,1002 , 20);
                    AddLootItem(orc,101 , 20);
                    return orc;

                case 5:
                    Monster giant =
                        new Monster("Giant", "gaint.png", 
                        8, 8, 2, 4, 25, 8);
                    AddLootItem(giant, 205, 75);
                    AddLootItem(giant, 104, 20);
                    AddLootItem(giant, 101, 20);

                    return giant;

                default:
                    throw new ArgumentException(string.Format("MonsterType '{0}' does not exist", monsterID));
            }
        }
       private static void AddLootItem(Monster monster, int itemID, int percentage)
        {
            if (RandomNumberGenerator.NumberBetween(1, 100) <= percentage)
            {
                monster.AddItemToInventory(ItemFactory.CreateGameItem(itemID));
            }
        }
    }
}
