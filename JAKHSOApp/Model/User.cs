using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JAKHSOApp.Model
{
   public class User
    {
        private int _userId;
        private string _nameOfUser;
        private string _surname;
        private string _userPassword;
        private string _userType;

        public int UserId
        {
            get { return _userId; }
            set { _userId = value; }
        }

        public string NameOfUser
        {
            get { return _nameOfUser; }
            set { _nameOfUser = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }
        }

        public string UserPassword
        {
            get { return _userPassword; }
            set { _userPassword = value; }
        }

        public string UserType
        {
            get { return _userType; }
            set { _userType = value; }
        }


        public User  (int userid,string nameofuser,string surname,string userpassword, string usertype)
        {
            _userId = userid;
            _nameOfUser = nameofuser;
            _surname = surname;
            _userPassword = userpassword;
            _userPassword = usertype;
        }

        public override string ToString()
        {
            return("NameOfUser:  " + _nameOfUser);
        }
    }
}
