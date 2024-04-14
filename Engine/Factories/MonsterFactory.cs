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
                        new Monster("Goblin", "pack://application:,,,/Engine;component/Images/Locations/Marshlands.png/goblin.png",
                                    5, 2, 10, 3);
                    AddLootItem(goblin, 201, 70);
                    AddLootItem(goblin, 101, 40);

                    return goblin;

                case 2:
                    Monster ghoul =
                        new Monster("Ghoul", " pack://application:,,,/Engine;component/Images/Locations/ghoul.png", 8, 3, 15, 5);
                    AddLootItem(ghoul, 202, 75);
                    AddLootItem(ghoul, 101, 40);
                    AddLootItem(ghoul, 1004, 40);
                    return ghoul;

                case 3:
                    Monster witches =
                        new Monster("Witch", " pack://application:,,,/Engine;component/Images/Locations/witches.png", 10, 5, 18, 5);
                    AddLootItem(witches, 203, 75);
                    AddLootItem(witches, 1004, 40);
                    AddLootItem(witches, 102, 10);
                  
                    return witches;

                case 4:
                    Monster orc =
                        new Monster("Orc", " pack://application:,,,/Engine;component/Images/Locations/orc.png", 12, 6, 20, 5);
                    AddLootItem(orc, 204, 75);
                    AddLootItem(orc,1002 , 20);
                    AddLootItem(orc,101 , 20);
                    return orc;

                case 5:
                    Monster giant =
                        new Monster("Giant", " pack://application:,,,/Engine;component/Images/Locations/giant.png", 15, 9, 25, 8);
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
                monster.Inventory.Add(new ItemQuantity(itemID, 1));
            }
        }
    }
}
