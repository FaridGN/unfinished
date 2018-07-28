using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingSystem.models
{
     class Network
    {
        public string Name;
        public Grade Grades;
        public Users[] User;
        public Markets[] Market = new Markets[5];

       public void Shops()
        {

            Market[0].Name = "NY";
            Market[0].ID = 1;

            Market[1].Name = "Mango";
            Market[1].ID = 2;

            Market[2].Name = "DG";
            Market[2].ID = 3;

            Market[3].Name = "Araz";
            Market[3].ID = 4;

            Market[4].Name = "Bravo";
            Market[4].ID = 5;
        }
       


    }
}
