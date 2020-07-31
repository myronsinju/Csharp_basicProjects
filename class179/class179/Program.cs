using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class179
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Sample = new Employee()
            {
                FirstName = "Sample",
                LastName = "Student",
                Id = 01
            };
            Employee JIFF = new Employee()
            {
                FirstName = "JIFF",
                LastName = "blockHead",
                Id = 01
            };

            IQuittable Bill = new Employee()
            {
                FirstName = "Bill",
                LastName = "Bob",
                Id = 4
            };
            Console.WriteLine(Sample.Id);
            Console.WriteLine(JIFF.Id);
            Console.WriteLine(Sample == JIFF);

            Bill.Quit();
            Sample.SayName();
            Console.ReadLine();
        }
    }
}
//1. Create an abstract class called Person with two properties: string firstName and string lastName.
//2. Give it the method SayName().
//3. Create another class called Employee and have it inherit from the Person class.
//4. Implement the SayName() method inside of the Employee class.
//5. Inside the Main() method, instantiate an Employee 
//    object with firstName "Sample" and lastName "Student". Call the SayName() method on the object.


//1. Create an abstract class called Person with two properties: string firstName and string lastName.
//This looks good.
//2. Give it the method SayName().
//There should only be the method name in this one, as you'll implement the method functionality in step 4.
//3. Create another class called Employee and have it inherit from the Person class.
//This looks good.
//4. Implement the SayName() method inside of the Employee class.
//This is currently not implementing the SayName() method, but is instead giving it a property of
//SayName that is data type string. It can be implemented
//the same way it is being written in the Person class, except that it should be
//    concatinating the FirstName and LastName properties rather than the FirstName property with the string 
//    "LastName". Make sure to test your code before submitting to ensure that it is working correctly.
//5. Inside the Main() method, instantiate an Employee object with firstName "Sample" and lastName "Student". 
//Call the SayName() method on the object.
//This looks good.
//Let us know if you have any questions!
