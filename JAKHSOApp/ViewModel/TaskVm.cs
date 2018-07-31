using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Interfaces;
using JAKHSOApp.Persistency;

namespace JAKHSOApp.ViewModel
{
    public class TaskVm
    {
        // Fields
        private ObservableCollection<Task> _taskCollection;

        private IPersistancyFactory<Task> _interfacePersistancy;
        
        // Properties
        public ObservableCollection<Task> TaskCollection
        {
            get { return _taskCollection; }
        }

        //Constructor

        public TaskVm()
        {
            _taskCollection = new ObservableCollection<Task>();
            _interfacePersistancy = new PersistencyFactory<Task>();
            _interfacePersistancy.Load("Tasks");

        }

    }
}
