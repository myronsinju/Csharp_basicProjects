using System;
using System.Collections.Generic;
using System.Linq;
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