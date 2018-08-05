using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Handlers;
using JAKHSOApp.Model;

namespace JAKHSOApp.ViewModel
{
     public class EquipmentVm
    {

        private TaskHandler _taskHandler;

        public ObservableCollection<Equipment> EquipmentCollection { get; set; }


        public EquipmentVm()
        {
            _taskHandler = new TaskHandler();
            EquipmentCollection = _taskHandler.RetriveEquipmentsCollection("Equipments");
        }


    }
}
