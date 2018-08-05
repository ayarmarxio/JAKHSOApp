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
        private IPersistancyFactory<Station> _loadStationkFromPersistancy = new PersistencyFactory<Station>();
        private IPersistancyFactory<Equipment> _loadEquipmentFromPersistancy = new PersistencyFactory<Equipment>();


       
        private FrameNavigate _frameNavigate;


        public ObservableCollection<Station> StationCollection { get; set; }

        //edit  putting equipment observablecollection
        public ObservableCollection<Equipment> EquipmentCollection { get; set; }

        

        public ObservableCollection<Model.Task> RetrievedUndoneTaskCollection(string targetTable)
        {
            ObservableCollection<Model.Task> taskCollection = _loadTaskFromPersistancy.RetrieveCollection(targetTable);
            return taskCollection;
        }

        public ObservableCollection<Station> RetrieveStationsCollection(string StargetTable)
        {
            ObservableCollection<Model.Station> StationCollection = _loadStationkFromPersistancy.RetrieveCollection(StargetTable);
            return StationCollection;

        }
        //putting equipment
        public ObservableCollection<Equipment> RetriveEquipmentsCollection(string StargetTable)
        {
            ObservableCollection<Model.Equipment> EquipmentCollection = _loadEquipmentFromPersistancy.RetrieveCollection(StargetTable);
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
