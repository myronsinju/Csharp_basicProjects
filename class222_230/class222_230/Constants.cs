using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class222_230
{
    public class Constants
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string empID { get; set; }
        public Constants(string firstName) : this(firstName, "Default lastName")
        {
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName!");
        }
        public Constants(string firstName, string lastName) : this(firstName, lastName, "XC007")
        {
            this.lastName = lastName;
            this.firstName = firstName;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName and lastName!");
        }
        public Constants(string firstName, string lastName, string empID)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.empID = empID;
            Console.WriteLine("Creating new record for the upcoming employee, with firstName, lastName, empID, position and team!");
        }
    }
}
