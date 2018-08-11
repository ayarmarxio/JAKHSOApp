using JAKHSOApp.Handlers;
using JAKHSOApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Commons;

namespace JAKHSOApp.ViewModel
{
    public class StationVM
    {

        private TaskHandler _taskHandler;
        
        public RelayCommand GoToEquipmentPage { get; set; }

        public ObservableCollection<Equipment> EquipmentsCollection
        {
            get { return _taskHandler.EquipmentCollection; }
        }
        public ObservableCollection<Model.Station> StationCollection { get; set; }


        public StationVM()
        {
            _taskHandler = new TaskHandler();
            StationCollection = _taskHandler. RetrieveStationCollection("Stations");
            GoToEquipmentPage = new RelayCommand(_taskHandler.GoToEquipmentPage);
        }
    }
}
