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

namespace JAKHSOApp.ViewModel
{
    public class TaskVm
    {
        // Fields
        private ObservableCollection<Model.Task> _taskCollection;
       
        private TaskHandler _taskHandler;
       
        
        // Properties
        public ObservableCollection<Model.Task> TaskCollection {get; set;}
       
        

        //Constructor

        public TaskVm()
        {
            _taskHandler = new TaskHandler();
            TaskCollection = _taskHandler.RetrievedUndoneTaskCollection("Tasks");            
        }

       
    }
}
