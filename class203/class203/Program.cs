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
            Employee feliz = new Employee() { FirstName = "Feliz", LastName = "Navida", Id = 3 };
            Employee swimming = new Employee() { FirstName = "Swimming", LastName = "Jankins", Id = 4 };
            Employee thorn = new Employee() { FirstName = "Thorn", LastName = "Butt", Id = 5 };
            Employee biggie = new Employee() { FirstName = "Biggie", LastName = "Smallzie", Id = 6 };
            Employee ajax = new Employee() { FirstName = "Ajax", LastName = "CrackSnap", Id = 7 };
            Employee milky = new Employee() { FirstName = "Milky", LastName = "Way", Id = 8 };
            Employee joe2 = new Employee() { FirstName = "Joe", LastName = "Big-Daddy", Id = 9 };
            Employee sharell = new Employee() { FirstName = "Sharell", LastName = "crept", Id = 10 };
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

            int count = nameList.Count(Employee => 5);//not sure how to do the lambda expression the video isn't making sense to me.
            

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