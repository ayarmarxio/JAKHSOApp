using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAKHSOApp.Model
{
   public class Equipment
    {
       private int _equipmentId;
        private string _equipmentName;
        private string _equipmentType;


        public int EquipmentId
        {
            get { return _equipmentId; }
            set { _equipmentId = value; }
        }
        public string EquipmentName
        {
            get { return _equipmentName; }
            set { _equipmentName = value; }
        }
        public string EquipmentType
        {
            get { return _equipmentType; }
            set { _equipmentType = value; }
        }

        public Equipment ( int equipmentid,string equipmentname,string equipmenttype)
        {
            _equipmentId = equipmentid;
            _equipmentName = equipmentname;
            _equipmentType = equipmenttype;
        }
    }
}
