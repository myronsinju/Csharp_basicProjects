using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "myron";
            string quote = "the man said, \"Hello\", Myron. \n Hello  again how are you today? \n \t hello this tab now. \t and yet again another tab how are you? \t and yet again another line \n this is a new line";
            Console.WriteLine(quote);

            bool trueOrFalse = name.Contains("s");
            trueOrFalse = name.EndsWith("s");

            int length = name.Length;
            name = name.ToUpper();
            Console.WriteLine(name);
            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Mr Myron Sinju");
            Console.WriteLine(sb);



            Console.ReadLine();
        }
    }
}
