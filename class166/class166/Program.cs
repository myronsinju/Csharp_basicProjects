using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class166
{
    class Program
    {
        static void Main(string[] args)
        {
            voidClass instance = new voidClass();
            Console.WriteLine("lets play with two numbers add one and display the other.");
            int response = Convert.ToInt32(Console.ReadLine());
            int response2 = Convert.ToInt32(Console.ReadLine());

            instance.twoMethod(a:response, b:response2);
            Console.ReadLine();
        }
    }
}
//1. Create a class. In that class, create a void method that takes two integers as parameters.
//    Have the method do a math operation on the first integer and display the second integer to the screen.

//2. In the Main() method of the console app, instantiate the class.

//3. Call the method in the class, passing in two numbers.

//4. Call the method in the class, specifying the parameters by name