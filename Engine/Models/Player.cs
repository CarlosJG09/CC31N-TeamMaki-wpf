using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : LivingEntity
    {
      
       
        private int _experiencePoints;
        private int _level;
        

       
      
        public int ExperiencePoints
        {
            get
            {
                return (_experiencePoints);
            }
            set
            {
                _experiencePoints = value;
                OnpropertyChanged(nameof(ExperiencePoints));
            }
        }
        public int Level
        {
            get
            {
                return (_level);
            }
            set
            {
                _level = value;
                OnpropertyChanged(nameof(Level));
            }
        }
     
        public ObservableCollection<QuestStatus> Quests { get; set; }
        public Player()
        {
            
            Quests = new ObservableCollection<QuestStatus> { };
        }

        public bool HasAllTheseItems(List<ItemQuantity> items)
        {
            foreach (ItemQuantity item in items)
            {
                if (Inventory.Count(i => i.ItemTypeID == item.ItemID) < item.Quantity)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
