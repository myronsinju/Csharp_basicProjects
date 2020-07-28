using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class165
{
    class Program
    {
        static void Main(string[] args)
        {
            newMethod instance = new newMethod();
            Console.WriteLine("input two numbers, but second number is not required");

            int answer = Convert.ToInt32(Console.ReadLine());

            try
            {
                int answer2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("your two numbers added together equals.." + instance.addMethod(answer, answer2));
            }
            catch(Exception)
            {
                Console.WriteLine("your number plus 2 equals.." + instance.addMethod(answer));
            }
            
            Console.ReadLine();
        }
    }
}

//1. Create a class. In that class, create a method that takes 
//    two integers as parameters.Make one of them optional.Have the method do a math operation and return an integer result.

//2. In the Main() method of the console app, instantiate the class.

//3. Ask the user to input two numbers, one at a time.
//    Let them know they need not enter anything for the second number.

//4. Call the method in the class, passing in the one or two numbers entered.

//5. Try various combinations of numbers on the code, including having no second number.