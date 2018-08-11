using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Commons;
using JAKHSOApp.Handlers;
using JAKHSOApp.Model;

namespace JAKHSOApp.ViewModel
{
     public class EquipmentVm
    {

        private TaskHandler _taskHandler;

        public RelayCommand GoToUserPage { get; set; }

        public ObservableCollection<User> UsersCollection
        {
            get { return _taskHandler.UserCollection; }
        }

        public ObservableCollection<Equipment> EquipmentCollection { get; set; }
       


        public EquipmentVm()
        {
            _taskHandler = new TaskHandler();
            EquipmentCollection = _taskHandler.RetriveEquipmentsCollection("Equipments");
            GoToUserPage = new RelayCommand(_taskHandler.GoToUserPage);
        }


    }
}
