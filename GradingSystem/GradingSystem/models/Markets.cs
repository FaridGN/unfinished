using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.models
{
    class Markets
    {
        public string Name;
        public int ID;
        public Employee[] Specialist = new Employee[4];
        public Grade[] Grades;
        public Users[] User;

        public void Employees()
        {
            Specialist[0].Name = "Samir";
            Specialist[0].Surname = "Aliyev";
            Specialist[0].ID = 1;
            Specialist[0].Position = "Manager";
        }
       
    }
}
