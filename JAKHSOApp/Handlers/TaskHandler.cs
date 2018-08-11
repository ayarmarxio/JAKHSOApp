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


       
        private FrameNavigate _frameNavigate;


        public ObservableCollection<Station> StationCollection { get; set; }

        internal void GoToUserPage()
        {
            throw new NotImplementedException();
        }

        //edit  putting equipment observablecollection
        public ObservableCollection<Equipment> EquipmentCollection { get; set; }
        public ObservableCollection<User> UserCollection { get; internal set; }

        public ObservableCollection<Model.Task> RetrievedUndoneTaskCollection(string targetTable)
        {
            ObservableCollection<Model.Task> taskCollection = _loadTaskFromPersistancy.RetrieveCollection(targetTable);
            return taskCollection;
        }

        public ObservableCollection<Station> RetrieveStationCollection(string targetTable)
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




    }
}
