using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadWrite
{
    internal class Program

    {
        static void Main2()
        {
            Console.WriteLine("Hello Worldsssdsfasd");
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


            Console.ReadLine();
        }
    }
}
