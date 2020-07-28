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
            Console.WriteLine("Take a number and have 2 added to it");
            int answer = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("your number chosen + 2 is.. " + newMethod.addMethod(answer));
            Console.ReadLine();

            Console.WriteLine("input two numbers, one at a time no need to enter anything for the second number");
            int input = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("you've chosen.. " + newMethod.someNum(input));
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