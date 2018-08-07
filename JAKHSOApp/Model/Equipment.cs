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
            get { return _equipmentId; } set { _equipmentId = value; }
        }
        public string EquipmentName
        {
            get { return _equipmentName; } set { _equipmentName = value; }
        }
        public string EquipmentType
        {
            get { return _equipmentType; }  set { _equipmentType = value; }
        }

        public Equipment ( int equipmentiId,string equipmentname,string equipmenttype)
        {
            _equipmentId = equipmentiId;
            _equipmentName = equipmentname;
            _equipmentType = EquipmentType;
        }

        public override string ToString()
        {
            return ("Hi my name is " + _equipmentName);
        }
    }
}
