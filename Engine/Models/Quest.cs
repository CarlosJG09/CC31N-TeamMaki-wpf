﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<ItemQuantity> ItemsToComplete {get; set;}
        public int ExpPoints { get; set; }
        public int Gold { get; set; }
        public List<ItemQuantity> RewardItems { get; set; }

       

    }
}