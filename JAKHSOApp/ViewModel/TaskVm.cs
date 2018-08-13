using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Handlers;
using JAKHSOApp.Interfaces;
using JAKHSOApp.Persistency;
using JAKHSOApp.Model;
using JAKHSOApp.Commons;

namespace JAKHSOApp.ViewModel
{
    public class TaskVm
    {
        // Fields
      
        private TaskHandler _taskHandler;

        public RelayCommand GoToStationPage { get; set; }
        //public RelayCommand GoToEquipmentPage { get; set; }

        public ObservableCollection<Equipment> EquipmentCollection
        {
            get { return _taskHandler.EquipmentCollection; }
        }

        public ObservableCollection<Station> StationCollection
        {
            get { return _taskHandler.StationCollection; }
        }

        // Properties
        public ObservableCollection<Model.Task> TaskCollection {get; set;}
        
        //Constructor

        public TaskVm()
        {
            _taskHandler = new TaskHandler();
            TaskCollection = _taskHandler.RetrievedUndoneTaskCollection("Tasks");
            GoToStationPage = new RelayCommand(_taskHandler.GoToStationPage);
        }


    }
}
