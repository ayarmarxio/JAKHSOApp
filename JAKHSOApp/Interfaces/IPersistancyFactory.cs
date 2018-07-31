using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAKHSOApp.Interfaces
{
    interface IPersistancyFactory<T>
    {
        Task<ObservableCollection<T>> Load(string apiId);
    }
}
