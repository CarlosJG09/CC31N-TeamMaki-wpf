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
    public static class ItemFactory
    {
        private static List<GameItem> _gameitems;
        static ItemFactory()
        {
           
            {
                _gameitems = new List<GameItem>();
                _gameitems.Add (new GameItem(101, "Health Potion", 20.0,"pack://application:,,,/Engine;component/Images/GameItems/health potion.png" ));
                _gameitems.Add (new GameItem(102, "Armor Helmet", 25.0, "pack://application:,,,/Engine;component/Images/GameItems/img_helmet.png"));
                _gameitems.Add (new GameItem(103, "Leather Boots", 15.0, "pack://application:,,,/Engine;component/Images/GameItems/img_boots.png"));
                _gameitems.Add (new GameItem(104, "Armor Chestplate", 30.0, "pack://application:,,,/Engine;component/Images/GameItems/img_chestplate.png"));
                _gameitems.Add (new GameItem(105, "gloves", 10.0, "pack://application:,,,/Engine;component/Images/GameItems/img_gloves.png"));  
                
                _gameitems.Add (new GameItem(201, "Goblins tooth", 5.0, "C:\\Users\\Win10\\Documents\\CC3\\CC31N- TeamMaki-wpf\\Engine\\Images\\GameItems\\goblins tooth.png"));             
                _gameitems.Add (new GameItem(202, "Ghouls eye", 10.0, "C:\\Users\\Win10\\Documents\\CC3\\CC31N- TeamMaki-wpf\\Engine\\Images\\GameItems\\ghoul eye.png"));             
                _gameitems.Add (new GameItem(203, "Witches Hat", 10.0, "C:\\Users\\Win10\\Documents\\CC3\\CC31N- TeamMaki-wpf\\Engine\\Images\\GameItems\\witches hat.png"));             
                _gameitems.Add (new GameItem(204, "Orc Tusk", 15.0, "C:\\Users\\Win10\\Documents\\CC3\\CC31N- TeamMaki-wpf\\Engine\\Images\\GameItems\\ork tusk.png"));             
                _gameitems.Add (new GameItem(205, "Giants Hand", 20.0, "C:\\Users\\Win10\\Documents\\CC3\\CC31N- TeamMaki-wpf\\Engine\\Images\\GameItems\\giant's hand.png"));             


                _gameitems.Add(new Weapon(1001, "Iron Sword", 30.0, "pack://application:,,,/Engine;component/Images/GameItems/iron sword.png", 5, 10));
                _gameitems.Add( new Weapon(1002, "Wooden Bow", 40.0, "pack://application:,,,/Engine;component/Images/GameItems/wooden bow.png", 5, 10));
                _gameitems.Add(new Weapon(1003, "Iron Axe", 45.0, "pack://application:,,,/Engine;component/Images/GameItems/iron axe.png", 5, 10));
                _gameitems.Add(new Weapon(1004, "Dagger", 25.0, "pack://application:,,,/Engine;component/Images/GameItems/dagger.png", 5, 10));
                _gameitems.Add(new Weapon(1005, "Iron Spear", 60.0, "pack://application:,,,/Engine;component/Images/GameItems/iron spear.png", 5, 10));

                
            }                                                                     
        }
                     
        public static GameItem CreateGameItem(int itemTypeID)
        {

            GameItem gameitem = _gameitems.FirstOrDefault(item => item.ItemTypeID == itemTypeID);

            if (gameitem != null)
            {
                return gameitem.Clone();
            }
            return null;
                  
        }
    }
}