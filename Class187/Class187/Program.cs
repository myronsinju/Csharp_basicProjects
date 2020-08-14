using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class187
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee sample = new Employee()
            {
                FirstName = "sample",
                LastName = "student",
                Id = 01, 
                Id2 = 01,
            };
            sample.SayName();
            Console.ReadLine();
        }
    }
}
//1. Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.
