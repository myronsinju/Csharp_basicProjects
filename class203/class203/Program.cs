using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace class203
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee max = new Employee() { FirstName = "Max", LastName = "Weiss", Id = 1 };
            Employee joe = new Employee() { FirstName = "Joe", LastName = "Bob", Id = 2 };
            List<Employee> nameList = new List<Employee>()
            {
                max , joe, 
            };

            List<Employee> joeList1 = new List<Employee>();
            foreach (Employee employee in nameList)
            {
                if (employee.FirstName == "Joe")
                {
                    joeList1.Add(employee);
                }
            }

            int count = nameList.Count(int => 5);
            Console.ReadLine();
        }
    }
}
//1. In the Main() method, create a list of at least 10 employees.Each employee should have a first and last name,
//as well as an Id.At least two employees should have the first name "Joe".
//2. Using a foreach loop, create a new list of all employees with the first name "Joe".
//3. Do the same thing again, but this time with a lambda expression.
//4. Using a lambda expression, make a list of all employees with an Id number greater than 5.

//.where.findAll search for lambda


//int count = deck.Cards.Count(x => x.Face == Face.Ace);
//List<Card> newList = deck.Cards.Where(x => x.Face == Face.King).ToList();
//List<int> numberList = new List<int>() { 1, 2, 3, 852, 709, 82 };
//int sum = numberList.Max();
//Console.WriteLine(sum);

//"Max Weiss", "Joe Bob", "Feliz Navida", "Swimming Jankins", "Thorn butt", "biggie Smallzy", "Ajax cracksnap",
//                "Milky way", "Joe Big-Daddy", "Sharell"