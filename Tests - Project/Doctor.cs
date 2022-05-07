using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests___Project
{
    public class Doctor
    {
        private String _Username;
        private String _Password;
        private String _ID;
        public Doctor()
        {
            _Username = "username";
            _Password = "password";
            _ID = "id";
        }
        public Doctor(String name, String password, String id)
        {
            _Username = name;
            _Password = password;
            _ID = id;
        }
        public String getUsername() { return _Username; }
        public String getPassword() { return _Password; }
        public String getID() { return _ID; }
    }
}
