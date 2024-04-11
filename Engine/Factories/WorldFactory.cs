using System;
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
                "pack://application:,,,/Engine;component/Images/Locations/KapsVillage.png"); 

            newWorld.AddLocation(0, -1, "Wicked Forest", "Dark and foreboding, the Wicked Forest is overrun by goblins, who have made it their domain.",
                "pack://application:,,,/Engine;component/Images/Locations/WickedForest.png");

            newWorld.AddLocation(1, 0, "Guild Dulenar", "A bustling hub of activity, Guild Dulenar is where adventurers like Auswi trade crystal shards for gold coins.",
                "pack://application:,,,/Engine;component/Images/Locations/Guild.png");

            newWorld.AddLocation(1, -1, "Market Place", "The Market Place is a bustling marketplace where merchants offer a variety of goods, from weapons and armor to potions and provisions.",
              "pack://application:,,,/Engine;component/Images/Locations/MarketPlace.jpg");

            newWorld.AddLocation(2, 0, "Shadow Forest", "Shrouded in darkness, Shadow Forest is infested with goblins and ghouls, posing a constant threat to travelers.",
              "pack://application:,,,/Engine;component/Images/Locations/ShadowForest.png");

            newWorld.AddLocation(2, -1, "Marshlands", "A murky expanse of swamps and marshes, this treacherous terrain is home to orcs and witches.",
              "pack://application:,,,/Engine;component/Images/Locations/Marshlands.png");

            newWorld.AddLocation(1, 1, "Elder Peaks", "Towering mountains and treacherous cliffs define the landscape of Elder Peaks, inhabited by formidable giants and cunning witches.",
              "pack://application:,,,/Engine;component/Images/Locations/ElderPeaks.png");

            newWorld.AddLocation(2, 1, " Haven Village", " A serene haven amidst the chaos of the outside world, Haven Village offers respite and comfort to weary travelers.",
              "pack://application:,,,/Engine;component/Images/Locations/HavenVillage.png");

            newWorld.AddLocation(3, 1, "Crop Farm", "Fields of lush green crops stretch as far as the eye can see in the Crop Farm, tended by hardworking farmers.",
              "pack://application:,,,/Engine;component/Images/Locations/CropFarm.png");
          
            return newWorld;
        }
    }
}
