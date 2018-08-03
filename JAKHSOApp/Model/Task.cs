using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAKHSOApp.Model
{
    public class Task
    {
        private int _taskId;
        private string _taskName;
        private string _taskSchedule;
        private string _registration;
        private string _taskType;
        private DateTime _dueDate;
        private DateTime _doneDate;
        private string _doneVar;

        public int TaskId
        {
            get { return _taskId; }
            set { _taskId = value; }
        }
        public string TaskName
        {
            get { return _taskName; }
            set { _taskName= value; }
        }

        public string TaskSchedule
        {
            get { return _taskSchedule; }
            set { _taskSchedule = value; }
        }

        public string Registration
        {
            get { return _registration; }
            set { _registration = value; }
        }

        public string TaskType
        {
            get { return _taskType; }
            set { _taskType= value; }
        }

        public DateTime DueDate
        {
            get { return _dueDate; }
            set { _dueDate = value; }
        }

        public DateTime DoneDate
        {
            get { return _doneDate; }
            set { _doneDate= value; }
        }

        public string DoneVar
        {
            get { return _doneVar; }
            set { _doneVar = value; }
        }

        public Task (int taskid, string taskname, string taskschedule, string tasktype,string registration,DateTime duedate,DateTime donedate, string donevar)
        {
            _taskId = TaskId;
            _taskName = taskname;
            _taskSchedule = taskschedule;
            _taskType = tasktype;
            _registration = registration;            
            _dueDate = duedate;
            _doneDate = donedate;
            _doneVar = donevar;
        }

        //public Task()
        //{

        //}

        public override string ToString()
        {
            return ("Hi my name is " +_taskName);
        }


    }
}
