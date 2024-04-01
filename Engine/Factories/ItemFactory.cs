using Engine.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Factories
{
    public class ItemFactory
    {
        private static List<GameItem> _gameitems;
        static ItemFactory()
        {
            _gameitems = new List<GameItem>
            {
                new GameItem(101, "Health Potion", 20.0,"pack://application:,,,/Engine;component/Images/GameItems/health potion.png" ),
                new GameItem(102, "Armor Helmet", 25.0,"pack://application:,,,/Engine;component/Images/GameItems/img_helmet.png" ),
                new GameItem(103, "Leather Boots", 15.0,"pack://application:,,,/Engine;component/Images/GameItems/img_boots.png" ),
                new GameItem(104, "Armor Chestplate", 30.0,"pack://application:,,,/Engine;component/Images/GameItems/img_chestplate.png" ),             
                new GameItem(105, "gloves", 10.0,"pack://application:,,,/Engine;component/Images/GameItems/img_gloves.png" ),             

                new Weapon(1001, "Iron Sword", 30.0, "pack://application:,,,/Engine;component/Images/GameItems/iron sword.png", 5, 10),
                new Weapon(1002, "Wooden Bow", 40.0, "pack://application:,,,/Engine;component/Images/GameItems/wooden bow.png", 5, 10),
                new Weapon(1003, "Iron Axe", 45.0, "pack://application:,,,/Engine;component/Images/GameItems/iron axe.png", 5, 10),
                new Weapon(1004, "Dagger", 25.0, "pack://application:,,,/Engine;component/Images/GameItems/dagger.png", 5, 10),
                new Weapon(1005, "Iron Spear", 60.0, "pack://application:,,,/Engine;component/Images/GameItems/iron spear.png", 5, 10),
            };                                                                      
        }
                     
        public static GameItem CreateGameItem(int itemTypeID)
        {

            var foundItem = _gameitems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (foundItem != null)
                return foundItem.Clone();
            return null;
        }


        public static Weapon CreateWeapon(int itemTypeID)
        {
            var foundItem = _gameitems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);
            if (foundItem != null)
                return foundItem.Clone() as Weapon;
            return null;
        }


    }
}