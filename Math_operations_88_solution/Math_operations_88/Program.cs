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
            double  A = 12.5;
            int doubleDivide = Convert.ToInt32(Console.ReadLine());
            int divideResult = (int)A;
            Console.WriteLine(divideResult);



            Console.WriteLine("Please enter a number to check if it is greater than 50");
            bool greaterthan = num1 > num2
                num1 = Any; num 2 = 50;




            Console.WriteLine("please enter a number to divide by 7");
            int quotient = Convert.ToInt32(Console.ReadLine());
            int quotientResults = quotient / 7;
            Console.WriteLine(quotientResults);





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