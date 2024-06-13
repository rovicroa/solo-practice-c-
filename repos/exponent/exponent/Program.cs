using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exponent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // METHOD HANDLING AND EXCEPTION HANDLING USING TRY CATCH // 
            try //TRY THIS CODE THAT MIGHT ENCOUNTER AN ERROR//
            { 
                Console.WriteLine("Please enter the base number followed by the exponent");
                uint baseNum = Convert.ToUInt32(Console.ReadLine());
                uint exNum = Convert.ToUInt32(Console.ReadLine());

                uint result = exp (baseNum, exNum);

                Console.WriteLine($"The answer of {baseNum} raised to the power of {exNum} is {result}");
                Console.ReadLine();
            }
            catch (System.FormatException e) //EXPLAIN THE ERROR ENCOUNTERED IN THE TRY CODE // 
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }  
            catch (System.OverflowException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadLine();
            }
            finally //FINALLY ALWAYS GETS EXCECUTED REGARDLESS IF THERE IS AN ERROR OR NOT
            {
                Console.WriteLine("Have a good day.");
                Console.ReadLine();
            }
        }

        static uint exp(uint baseNum, uint exNum)
        {
            uint i;
            uint newNum = baseNum;
            if (exNum == 0)
            {
                return newNum = 1;
            }
            else if (exNum == 1)
            {
                return newNum;
            }
            else
            {
                for (i = 1; i < exNum; i++)
                {
                    newNum = newNum * baseNum;
                }
                return newNum;
            }

            
        }
    }
}
