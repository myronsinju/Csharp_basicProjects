using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace daily_report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy \nStudent Daily Report");

            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();

            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();

            Console.WriteLine("What Page are you on?");
            int page = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Do you need help with anything ? Please answer “true” or “false”.");
            bool needHelp =Convert.ToBoolean(Console.ReadLine());

            //string helpStatus = Convert.ToString(helpStatus);
            Console.WriteLine("Were there any positive experiences you’d like to share ? Please give specifics.");
            string yourAnswer = Console.ReadLine();

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedback = Console.ReadLine();

            Console.WriteLine("How many hours did you study today?");
            int hours = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
            
        }
    }
}
