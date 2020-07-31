using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class179
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + LastName + Id);
        }
        public void Quit()
        {
            Console.WriteLine("I quit");
        }
        public static bool operator ==(Employee one, Employee two)
        {
            return one.Id == two.Id;
        }
        public static bool operator !=(Employee one, Employee two)
        {
            return one.Id != two.Id;
        }
    }
    
}
//1. Create an interface called IQuittable and have it define a void method called Quit().

//2. Have your Employee class from the previous drill inherit that interface and implement the Quit() method in any way you choose.

//3. Use polymorphism to create an object of type IQuittable and call the Quit(
//) method on it. Hint: an object can be of an interface type if it implements that specific interface

//Overload the "==" operator so it checks if two Employee objects are equal by comparing their Id property.