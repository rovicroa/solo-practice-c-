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
            Console.WriteLine("Hello Worldfdsf");
            Console.WriteLine("Hello World");

            string charName = "Johnny Chris Hendicks";
            int charAge = 35;
            char grade = 'A';
            double GPA = 3.2;
            bool isMale = true;
            /* float , double, decimal  \n*/

            Console.WriteLine("There once was a man named \"" + charName + "\"." + "\nHe was " + charAge + " years old.");
            Console.WriteLine("He really liked the name " + charName + ".");
            Console.WriteLine("But he didnt like being " + charAge + ".");
            /* console write for writing in same line */

            int length = charName.Length;

            Console.WriteLine("str length is " + length + ".");
            /* str length */

            string upper = charName.ToUpper();
            string lower = charName.ToLower();
            Console.WriteLine(upper + lower);
            /*converts to upper and lower */

            Console.WriteLine(lower.Contains("chris"));
            Console.WriteLine(upper[2]);
            /*sees if it contains chris and prints out the letter in index 2 */

            Console.WriteLine(charName.Substring(4, 5));
            /* prints from the 4th index in charName and length is 5 characaters */

            int[] luckyNumbers = { 4, 5, 6, 7 };
            Console.WriteLine(luckyNumbers[2]);

            string[] friends = new string[3];
            friends[0] = "JIM";
            friends[1] = "PAT";
            friends[2] = "ENZ";
            Console.WriteLine(friends[0] + friends[1] + friends[2]);
            /* array */

            sayHi();
            sayHi2("Mike", 33);
            /* CALL METHODS OR FUNCTIONS */

            Console.ReadLine();
        }

        static void sayHi()
        {
            Console.WriteLine("Hello User");
        }

        static void sayHi2(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", your age is " + age +".");
        }
    }
}
