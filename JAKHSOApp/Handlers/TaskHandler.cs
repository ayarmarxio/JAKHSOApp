using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Persistency;

namespace JAKHSOApp.Handlers
{
     public class TaskHandler
     {
         private IpersistancyFactory<Model.Task> _loadTaskFromPersistencyFactory = new PersistencyFactory<Model.Task>();

         public ObservableCollection<Model.Task> RetrivedUndoneTaskCollection(string targetTable)
         {
             ObservableCollection<Model.Task> taskCollection =
                 _loadTaskFromPersistencyFactory.Retrivedcollection(targetTable);
         }
     }
}
