using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAKHSOApp.Model
{
    public class Station
    {
        private int _stationId;
        private string _stationName;
        private string _stationAddress;

        public int StationId
        {
            get { return _stationId; }
            set { _stationId = value; }
        }

        public string StationName
        {
            get { return _stationName; }
            set { _stationName = value; }
        }

        public string StationAdress
        {
            get { return _stationAddress; }
            set { _stationAddress = value; }
        }

        public Station ( int stationid,string stationname,string stationadress)
        {
            _stationId = stationid;
            _stationName = stationname;
            _stationAddress = stationadress;
        }

        public override string ToString()
        {
            return ("Hi my name is " + _stationName);
        }
    }
}
