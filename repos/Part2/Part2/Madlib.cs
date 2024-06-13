using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
        
    {
        static void Main(string[] args)
        {
            string name;

            Console.Write("Hello, please enter your name: ");
            name = Console.ReadLine();
            Console.WriteLine("Hello, " + name + ", good to see you.");

            Console.Write("Please enter a color: ");
            string color = Console.ReadLine();

            Console.Write("Please enter a plural noun: ");
            string pluralNoun = Console.ReadLine();

            Console.Write("Please enter a celebrity name: ");
            String celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + color + ".");
            Console.WriteLine(pluralNoun + " are blue.");
            Console.WriteLine("I love " + celebrity + ".");

            Console.ReadLine();
        }
    }
}
