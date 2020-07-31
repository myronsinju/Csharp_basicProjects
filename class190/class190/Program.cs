using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace class190
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> Jane = new Employee<string>()
            {
                things = new List<string>{ "Makeup", "Hair brush", "tooth paste", "chapstick", "chewing gum" }
            };
            Employee<int> Purse = new Employee<int>()
            {
                things = new List<int>{ 01, 04, 03, 07, 09 }
            };
            foreach (string thing in Jane.things)
            {
                Console.WriteLine(thing);
            }
            foreach (int thing in Purse.things)
            {
                Console.WriteLine(thing);
            }
            Console.ReadLine();
        }
    }
}
//1. Make the Employee class take a generic type parameter.
//2. Add a property to the Employee class called "things" and have its data type be a generic list matching the generic type of the class.
//3. Instantiate an Employee object with type "string" as its generic parameter.Assign a list of strings as the property value of Things.
//4. Instantiate an Employee object with type "int" as its generic parameter.Assign a list of integers as the property value of Things.
//5. Create a loop that prints all of the Things to the Console.