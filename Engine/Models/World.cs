using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Models
{
    public class World
    {
        private List<Location> _locations = new List<Location>();
        
        internal void AddLocation (int x, int y, string name, string description, string ImageName)
        {
            Location location = new Location();
            location.XCoordinate = x;
            location.YCoordinate = y;
            location.Name = name;
            location.Description = description;
            location.ImageName = ImageName;

            _locations.Add(location);
        }
         public Location LocationAt(int x ,int y)
        {
            foreach(Location loc in _locations)
            {
                if(loc.XCoordinate == x && loc.YCoordinate == y)
                {
                    return loc;
                }
            }
            return null;
        }
    }
}
