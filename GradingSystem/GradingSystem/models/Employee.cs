using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.models
{
    class Employee
    {
        public string Name;
        public string Surname;
        public int ID;
        public int Grade;
        
    }

    public enum Position
    {
        Manager,
        Senior,
        Salesman,
        Sales Assistant
    }
}
