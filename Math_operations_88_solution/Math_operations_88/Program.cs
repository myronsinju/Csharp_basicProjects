using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Math_operations_88
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please input a number to multiply by 50");
            int userInput = Convert.ToInt32(Console.ReadLine());
            int result = userInput * 50;
            Console.WriteLine(result);

            Console.WriteLine("Please input a number to add by 25");
            int userInputadd = Convert.ToInt32(Console.ReadLine());
            int addResults = userInputadd + 25;
            Console.WriteLine(addResults);

            Console.WriteLine("Please input a number to divide by 12.5");
            double A = 12.5;
            int doubleDivide = Convert.ToInt32(Console.ReadLine());
            double divideResult = doubleDivide / A;
            Console.WriteLine(divideResult);

            Console.WriteLine("Please enter a number to check if it is greater than 50");
            int greaterThan = Convert.ToInt32(Console.ReadLine());
            bool boolResult = greaterThan > 50;
            Console.WriteLine(boolResult);






            Console.WriteLine("please enter a number to divide by 7 and we will show you the remainder");
            int remainder = Convert.ToInt32(Console.ReadLine());
            int remainderResults = remainder % 7;
            Console.WriteLine(remainderResults);





            Console.ReadLine();
        }
    }
}



//1. Takes an input from the user, multiplies it by 50, then prints the result to the console. 
//(Note: make sure your code can take inputs larger than 10,000,000).

//2. Takes an input from the user, adds 25 to it, then prints the result to the console.

//3. Takes an input from the user, divides it by 12.5, then prints the result to the console.

//4. Takes an input from the user, checks if it is greater than 50, then prints the true/false result to the console.

//5. Takes an input from the user, divides it by 7, then prints the remainder to the console (tip: think % operator).


//There are some issues here.

//#3
//This is just returning 12 every time.It also isn't returning a double type.

//#4
//You got the right idea to use a > comparison.
//You need to get user input and compare it to 50.

//#5
//This should use the % operator to return the remainder in a division operation.

//See what you can do to fix these.

//I recommend reviewing the two math and comparison videos in the previous slides.I think that would clear a lot up.

//Let us know if you get stuck or need some help.

//-Holden