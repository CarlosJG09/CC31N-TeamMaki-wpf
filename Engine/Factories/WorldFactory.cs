﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Engine.Models;

namespace Engine.Factories
{
    internal class WorldFactory
    {
        public static World CreateWorld()
        {
            World newWorld = new World();
            newWorld.AddLocation(0, 0, "Kaps Village", "A quaint village nestled amidst lush greenery, Kaps Village serves as the humble home of our hero, Auswi.",
                "KapsVillage.png"); 

            newWorld.AddLocation(0, -1, "Wicked Forest", "Dark and foreboding, the Wicked Forest is overrun by goblins, who have made it their domain.",
                "WickedForest.png");

            newWorld.LocationAt(0, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestID(1));
            newWorld.LocationAt(0, -1).AddMonster(1, 25);

            newWorld.AddLocation(1, 0, "Guild Dulenar", "A bustling hub of activity, Guild Dulenar is where adventurers like Auswi trade crystal shards for gold coins.",
                "Guild.png");

            newWorld.AddLocation(1, -1, "Market Place", "The Market Place is a bustling marketplace where merchants offer a variety of goods, from weapons and armor to potions and provisions.",
              "MarketPlace.jpg");

            newWorld.LocationAt (1, -1).TraderHere =
                TraderFactory.GetTraderByName("Merchant");
            newWorld.LocationAt (1, -1).TraderHere =
                TraderFactory.GetTraderByName("Shopowner");

            newWorld.AddLocation(2, 0, "Shadow Forest", "Shrouded in darkness, Shadow Forest is infested with goblins and ghouls, posing a constant threat to travelers.",
              "ShadowForest.png");
            newWorld.LocationAt(2, 0).QuestsAvailableHere.Add(QuestFactory.GetQuestID(2));
            newWorld.LocationAt(2, 0).AddMonster(2, 25);

            newWorld.AddLocation(2, -1, "Marshlands", "A murky expanse of swamps and marshes, this treacherous terrain is home to orcs and witches.",
              "Marshlands.png");
            newWorld.LocationAt(2, -1).QuestsAvailableHere.Add(QuestFactory.GetQuestID(3));
            newWorld.LocationAt(2, -1).AddMonster(3, 25);

            newWorld.AddLocation(1, 1, "Elder Peaks", "Towering mountains and treacherous cliffs define the landscape of Elder Peaks, inhabited by formidable giants and cunning witches.",
              "ElderPeaks.png");

            newWorld.LocationAt(1, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestID(4));
            newWorld.LocationAt(1, 1).AddMonster(4, 25);

            newWorld.AddLocation(2, 1, " Haven Village", " A serene haven amidst the chaos of the outside world, Haven Village offers respite and comfort to weary travelers.",
              "HavenVillage.png");

            newWorld.AddLocation(3, 1, "Crop Farm", "Fields of lush green crops stretch as far as the eye can see in the Crop Farm, tended by hardworking farmers.",
              "CropFarm.png");

            newWorld.LocationAt(3, 1).QuestsAvailableHere.Add(QuestFactory.GetQuestID(5));
            newWorld.LocationAt(3, 1).AddMonster(5, 25);

            return newWorld;
        }
    }
}
