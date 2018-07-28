using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.models
{
    class Users
    {
        public string Name;
        public int ID;
        public string Password;
        public enum Role
        {
            Admin,
            User
        }
    }
}
