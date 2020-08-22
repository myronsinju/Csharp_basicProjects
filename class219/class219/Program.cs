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
            Console.WriteLine("Hello User can we get a number?");
            string askNumber = Console.ReadLine();
            File.WriteAllText(@"C:\Users\18015\myProjects\Csharp_basicProjects\class219\number.txt", askNumber);
            string readFile = File.ReadAllText(@"C:\Users\18015\myProjects\Csharp_basicProjects\class219\number.txt");
            Console.WriteLine("This file says: " + readFile);
            Console.ReadLine();
            //string askNumber2 = string.Format();
            //using (StreamWriter file = new StreamWriter)
        }
    }
}
//1. Ask the user for a number.
//2. Log that number to a text file.
//3. Print the text file back to the user.