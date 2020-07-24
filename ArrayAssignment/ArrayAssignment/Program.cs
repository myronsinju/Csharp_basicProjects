using System;
using System.Collections.Generic;


namespace ArrayAssignment
{
    class Program
    {
        static void Main()
        {
            string[] phrases = new string[] { "what are you up to?", "How is the day?", "Is it hot outside?", "Are you a fan of cheese?",
            "whats new scooby-doo?"};
            Console.WriteLine("please choose a index number between 0-4");

            Console.WriteLine(phrases);
            int input = int.Parse(Console.ReadLine());
            Console.WriteLine(phrases[input]);
            Console.ReadLine();

            int[] numArray = new int[] { 7, 14, 3300, 29, 85, 3 };
            Console.WriteLine("please select an index number of the array");
            Console.WriteLine(numArray);
            int input2 = int.Parse(Console.ReadLine());
            Console.WriteLine(numArray[input2]);
        Retrypoint:
            int a = int.Parse(Console.ReadLine());
            if ((a > 0) && (a <= 5));
            else
            {
                Console.WriteLine("the number you selected of the array does not exist please enter a whole number less than 5 ");
                goto Retrypoint;
            }
            Console.ReadLine();
        }
    }
}




////int[] numArray1 = new int[] { 5, 10, 546, 1525, 2368 };

//Console.WriteLine(cisTuition[index]);

//int input = int.Parse(Console.ReadLine());
//Console.WriteLine("value is: " + cisTuition[input]);
