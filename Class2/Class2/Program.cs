﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("type up a number for a math operation of addition");
            int adding = Convert.ToInt32(Console.ReadLine());
            myMethod myClass = new myMethod();

            Console.WriteLine("your number plus 20 equals passing it on as an integer " + myClass.mathM(adding));
            Console.ReadLine();

            //1. Create a class. In that class, create a method that will take in an integer, create a math
            //    operation for this integer (addition, subtraction, etc.), then return the answer as an integer.

            //2. In the Main() method of the console app, instantiate the class and call the one method, 
            //    passing in an integer.Display the result to the screen.

            Console.WriteLine("your number divided by 2.5 equals");
            decimal divDec = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("your number is being passed on & being divided by 2.5 which equals.. " + myClass.mathM(divDec));
            Console.ReadLine();

            //3. Add a second method to the class with the same name that will take in a decimal, 
            //    create a different math operation for it, then return the answer as an integer.

            //4. In the Main() method of the console app, instantiate the class and call the second method, 
            //    passing in a decimal. Display the result to the screen.

            Console.WriteLine("input a number ");
            string Name = Console.ReadLine();
            
            Console.WriteLine("your number times 45 is equal to.." + myClass.mathM(Name));
            Console.ReadLine();

            //5. Add a third method to the class, with the same name, that will take in a string, convert it to an integer if possible, 
            //    do a different math operation to it, then return the answer as an integer.

            //6. In the Main() method of the console app, instantiate the class and call the third method, 
            //    passing in a string that equates to an integer.Display the result to the screen.
        }
    }
}












