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
       
        private FrameNavigate _frameNavigate;


        public ObservableCollection<Station> StationCollection { get; set; }
        

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
       
        public void GoToStationPage()
        {
            _frameNavigate = new FrameNavigate();
            _frameNavigate.ActivateFrameNavigation(typeof(StationPage));
        }

       
    }
}
