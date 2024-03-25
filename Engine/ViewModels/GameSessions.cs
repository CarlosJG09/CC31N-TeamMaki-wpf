using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Engine.ViewModels
{


    public class GameSessions : INotifyPropertyChanged
    {
        private Location  _currentLocation;
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnpropertyChanged("CurrentLocation");
                OnpropertyChanged("HasLocationToNorth");
                OnpropertyChanged("HasLocationToWest");
                OnpropertyChanged("HasLocationToEast");
                OnpropertyChanged("HasLocationToSouth");
             
            }
        }
        public bool HasLocationToNorth 
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
             
        }
        public bool HasLocationToWest
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate -1, CurrentLocation.YCoordinate ) != null;
            }

        }
        public bool HasLocationToEast
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate +1, CurrentLocation.YCoordinate ) != null;
            }

        }
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }

        }


        public World CurrentWorld { get; set; }
        public GameSessions()
        {
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Auswi";
            CurrentPlayer.Gold = 100;
            CurrentPlayer.HitPoints = 0;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 0;
            CurrentPlayer.Crystalshards = 0;


            WorldFactory worldfactory = new WorldFactory();
            CurrentWorld = worldfactory.CreateWorld();

            CurrentLocation = CurrentWorld.LocationAt(0, 0);

        }
        public event PropertyChangedEventHandler? PropertyChanged;
        public virtual void OnpropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate );
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate +1, CurrentLocation.YCoordinate );
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
        }
        





    }
}
