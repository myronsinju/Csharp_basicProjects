using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace createClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("put a number in for math operations");
            int product = Convert.ToInt32(Console.ReadLine());


            

            Console.WriteLine("your number plus 5 equals " + someClass.add5(product));
            Console.WriteLine("your number subtracted by 5 equals " + someClass.sub5(product));
            Console.WriteLine("your number multipled by 10 equals " + someClass.mult10(product));
            Console.ReadLine();
        }
        
    }
}









//IN A CONSOLE APP, CREATE CODE THAT DOES THE FOLLOWING:

//1. Create a class. In that class, create three methods, each of which will take one integer parameter
//in and return an integer.The methods should do some math operation on the received parameter.
//    Put this class in a separate.cs file in the application.

//2. In the Main() program, ask the user what number they want to do the math operations on.

//3. Call each method in turn, passing the user input to the method.Display the returned integer to the screen.