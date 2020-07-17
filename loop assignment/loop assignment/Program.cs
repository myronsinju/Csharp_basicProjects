using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loop_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a #?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 8;
            do
            {
                switch (number)
                {
                    case 3:
                        Console.WriteLine("You guessed 3. Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("You guessed 7, Try again");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 87:
                        Console.WriteLine("you guessed 87, Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 8:
                        Console.WriteLine("you guessed 8. That is Correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("you're wrong.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }
            while (!isGuessed);


            Console.Read();
        }
    }
}
