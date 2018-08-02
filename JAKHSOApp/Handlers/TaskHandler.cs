using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Interfaces;
using JAKHSOApp.Persistency;
using JAKHSOApp.Model;

namespace JAKHSOApp.Handlers
{
    public class TaskHandler
    {
       
        private IPersistancyFactory<Model.Task>  _loadTaskFromPersistancy = new PersistencyFactory<Model.Task>();

        public ObservableCollection<Model.Task> RetrievedUndoneTaskCollection(string targetTable)
        {
            ObservableCollection<Model.Task> taskCollection = _loadTaskFromPersistancy.RetrieveCollection(targetTable);
            return taskCollection;
        }
    }
}
