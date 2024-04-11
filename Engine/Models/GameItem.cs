using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
   public class GameItem

    {
        public int ItemTypeID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageName { get; set; }

        public GameItem(int itemTypeID, string name, double price, string imageName) 
        {
            ItemTypeID = itemTypeID;
            Name = name;
            Price = price;
            ImageName = imageName;
        }
        public  GameItem Clone()
        {
            return new GameItem(ItemTypeID, Name, Price, ImageName);
        }
    }
}
