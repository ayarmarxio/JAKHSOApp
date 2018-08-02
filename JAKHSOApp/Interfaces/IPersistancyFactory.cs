using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JAKHSOApp.Model;

namespace JAKHSOApp.Interfaces
{
    interface IPersistancyFactory<T>
    {
        Task<ObservableCollection<T>> Load(string apiId);

        ObservableCollection<T> RetrieveCollection(string targetTable);
    }
}
