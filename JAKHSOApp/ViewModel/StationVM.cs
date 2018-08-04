using JAKHSOApp.Handlers;
using JAKHSOApp.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAKHSOApp.ViewModel
{
    public class StationVM
    {

        private TaskHandler _taskHandler;

        public ObservableCollection<Station> StationCollection  { get; set; }


        public StationVM()
        {
            _taskHandler = new TaskHandler();
            StationCollection = _taskHandler.RetrieveStationsCollection("Stations");
        }
    }
}
