using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace les_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;
            x = 7;
            y = x + 3;
            ConsoleWriteLine(y);
            ConsoleReadLine();
            */
            Console.WriteLine("what is your name?");
            Console.Write("type your first name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();

            string myLastName;
            Console.Write("type your last name: ");
            myLastName = Console.ReadLine();
            Console.WriteLine("hello, " + myFirstName + "" + myLastName);

        }
    }
}
