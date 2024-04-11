using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Player : BaseNotificationClass
    {
        private string _name;
        private int _hitPoints;
        private int _experiencePoints;
        private int _level;
        private int _gold;

        public string Name
        {
            get 
            { return _name; }
            set
            {
                _name = value;
                OnpropertyChanged(nameof(Name));
            }
        }
        public int HitPoints 
        {
            get
            {
                return _hitPoints;
            }
            set
            {
                _hitPoints = value;
                OnpropertyChanged(nameof(HitPoints));   
            }
        }
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
                return (int)_level;
            }
            set
            {
                _level = value;
                OnpropertyChanged(nameof(Level));
            }
        }
        public int Gold 
        {
            get
            {
                return(_gold);
            }
            set
            {
                _gold = value;  
                OnpropertyChanged(nameof(Gold));
            }
        }
        public int Crystalshards 
        {
            get; set;
        }
        
        public ObservableCollection<GameItem> Inventory {  get; set; }

        public Player()
        {
            Inventory = new ObservableCollection<GameItem>();  
        }
    }
}
