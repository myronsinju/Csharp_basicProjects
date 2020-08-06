using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace class219
{
    class Program
    {
        static void Main(string[] args)
        {
            string assignment = "Yo GABBA GABBA WHATS UP";
            File.WriteAllText(@"C:\Users\18015\Documents\assignment.txt\", assignment);

            Console.WriteLine("Hello User can we get a number?");
            int askNumber = Convert.ToInt32(Console.ReadLine());//having a issue implementing the streamwriter command 
            //string askNumber2 = string.Format();
            //using (StreamWriter file = new StreamWriter)
        }
    }
}
//1. Ask the user for a number.
//2. Log that number to a text file.
//3. Print the text file back to the user.