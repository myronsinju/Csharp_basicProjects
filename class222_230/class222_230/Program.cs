using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class222_230
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Current Date and Time is : ");
            DateTime now = DateTime.Now;
            Console.WriteLine(now);


            Console.WriteLine("please enter a number.");
            int answer = Convert.ToInt32(Console.ReadLine());
            DateTime addHours = now.AddHours(answer);
            Console.WriteLine("the time in " + answer + " hours will be " + addHours);
                //dt2 = dt1.AddHours(48);

            double radius = 5.3;
            double area = 3 / 2 * (radius * radius);
            var test = "test";
            Console.WriteLine(test.GetType());

            const string A = "Hi";
            Console.WriteLine(A);

            var info = 149476000 / 2;
            Console.WriteLine(info.GetType());

            Console.WriteLine("Constructors");
            Constants C = new Constants("Myron", "S", "007");
            Console.WriteLine("First construct!");
            Constants L = new Constants("The","guy");
            Console.WriteLine("Second construct!");
            Constants F = new Constants("Daniel");
            Console.WriteLine("Third construct!");
            Constants M = new Constants("Daniel", "Szabo");
            Console.ReadKey(); ;
            Console.ReadLine();
        }
    }
}
//1. Prints the current date and time to the console.
//2. Asks the user for a number.
//3. Prints to the console the exact time it will be in X hours, X being the number the user entered in step 2.

//1. Create a const variable.
//2. Create a variable using the keyword "var".
//3. Chain two constructors together.