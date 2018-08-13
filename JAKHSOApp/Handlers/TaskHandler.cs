using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Interfaces;
using JAKHSOApp.Persistency;
using JAKHSOApp.Model;
using JAKHSOApp.Commons;
using JAKHSOApp.View;

namespace JAKHSOApp.Handlers
{
    public class TaskHandler
    {
       
        private IPersistancyFactory<Model.Task> _loadTaskFromPersistancy = new PersistencyFactory<Model.Task>();
        private IPersistancyFactory<Model.Station> _loadStationkFromPersistancy = new PersistencyFactory<Model.Station>();
        private IPersistancyFactory<Model.Equipment> _loadEquipmentFromPersistancy = new PersistencyFactory<Model.Equipment>();
        private IPersistancyFactory<Model.User> _loadUserFromPersistancy = new PersistencyFactory<Model.User>();


        private FrameNavigate _frameNavigate;

        //internal void GoToUserPage()
        //{
        //    throw new NotImplementedException();
        //}
        public ObservableCollection<Station> StationCollection { get; set; }



        //edit  putting equipment observablecollection
        public ObservableCollection<Equipment> EquipmentCollection { get; set; }

        public ObservableCollection<User> UserCollection { get; set; }


        public ObservableCollection<Model.Task> RetrievedUndoneTaskCollection(string targetTable)
        {
            ObservableCollection<Model.Task> taskCollection = _loadTaskFromPersistancy.RetrieveCollection(targetTable);
            return taskCollection;
        }

        public ObservableCollection<User> RetriveUndoneUserCollection(string targetTable)
        {
            ObservableCollection<User> userCollection = _loadUserFromPersistancy.RetriveCollection(targetTable);
            return UserCollection;
        }
        public ObservableCollection<Model.Station> RetrieveStationCollection(string targetTable)
        {
            ObservableCollection<Model.Station> StationCollection = _loadStationkFromPersistancy.RetrieveCollection(targetTable);
            return StationCollection;

        }
        //putting equipment
        public ObservableCollection<Equipment> RetriveEquipmentsCollection(string targetTable)
        {
            ObservableCollection<Model.Equipment> EquipmentCollection = _loadEquipmentFromPersistancy.RetrieveCollection(targetTable);
            return EquipmentCollection;
        }




        public void GoToStationPage()
        {
            _frameNavigate = new FrameNavigate();
            _frameNavigate.ActivateFrameNavigation(typeof(StationPage));
        }

        //putting equipment
        public void GoToEquipmentPage()
        {
            _frameNavigate = new FrameNavigate();
            _frameNavigate.ActivateFrameNavigation(typeof(EquipmentPage));
        }

        public void GoToUserPage()
        {
            _frameNavigate = new FrameNavigate();
            _frameNavigate.ActivateFrameNavigation(typeof(UserPage));
        }


    }
}
