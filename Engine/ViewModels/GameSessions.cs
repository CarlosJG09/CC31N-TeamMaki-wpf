using Engine.EventArgs;
using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Engine.ViewModels
{


    public class GameSessions : BaseNotificationClass
    {
        public event EventHandler<GameMessageEventArgs> OnMessageRaised;
      

        private Location  _currentLocation;
        private Monster _currentMonster;
        public Player CurrentPlayer { get; set; }
        public World CurrentWorld { get; set; }
        public Location CurrentLocation
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnpropertyChanged(nameof(CurrentLocation));
                OnpropertyChanged(nameof(HasLocationToNorth));
                OnpropertyChanged(nameof(HasLocationToWest));
                OnpropertyChanged(nameof(HasLocationToEast));
                OnpropertyChanged(nameof(HasLocationToSouth));

                GivePlayerQuestAtLocation();
                GetMonsterAtLocation();

            }

        }
        public Monster CurrentMonster
        {
            get {return _currentMonster;}
            set
            {
               _currentMonster = value;
                OnpropertyChanged(nameof(CurrentMonster));
                OnpropertyChanged(nameof(HasMonster));

                if (CurrentMonster != null)
                {
                    RaiseMessage("");
                    RaiseMessage($"You see aa {CurrentMonster.Name} here!");
                }
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
        public bool HasMonster => CurrentMonster != null;
        public GameSessions()
        {
            CurrentPlayer = new Player
            {
                Name = "Auswi",
                Gold = 100,
                HitPoints = 0,
                ExperiencePoints = 0,
                Level = 1,
                Crystalshards = 0,
               

            };
        
          
            CurrentWorld = WorldFactory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(0, 0);

           
        }
       
        public void MoveNorth()
        {
            if (HasLocationToNorth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
            }
        }
        public void MoveWest()
        {
          if (HasLocationToWest)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
            }
        }
        public void MoveEast()
        {
            if (HasLocationToEast)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
            }
        }
        public void MoveSouth()
        {
           if (HasLocationToSouth)
            {
                CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1);
            }
        }

        private void GivePlayerQuestAtLocation()
        {
            foreach (Quest quest in CurrentLocation.QuestsAvailableHere) 
            {
                if (!CurrentPlayer.Quests.Any(q => q.PlayerQuest.ID == quest.ID)) 
                {
                    CurrentPlayer.Quests.Add(new QuestStatus(quest));   
                }

            }
        }
        private void GetMonsterAtLocation()
        {
            CurrentMonster = CurrentLocation.GetMonster();
        }

        private void RaiseMessage(string message)
        {
            OnMessageRaised?.Invoke(this, new GameMessageEventArgs(message));
        }


    }
}
