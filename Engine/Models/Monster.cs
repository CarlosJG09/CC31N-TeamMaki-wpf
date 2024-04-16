using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Monster : LivingEntity
    {
      
        public string ImageName { get; set; }
     
        
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperiencePoints { get; private set; }
       

        public Monster(string name, string imageName,
                        int maximumHitPoints, int hitPoints,
                        int minimumDamage, int maximumDamage,
                        int rewardExperiencePoints, int rewardGold)
        {
            Name = name;
            ImageName = $"C:\\Users\\Win10\\Documents\\CC3\\CC31N- TeamMaki-wpf\\Engine\\Images\\Monsters\\{imageName}";
            MaximumHitPoints = maximumHitPoints;
            CurrentHitPoints = hitPoints;
            MinimumDamage = minimumDamage;
            MaximumDamage = maximumDamage;
            RewardExperiencePoints = rewardExperiencePoints;
            Gold = rewardGold;          
        }
    }
}
