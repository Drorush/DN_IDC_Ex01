using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex01_03
{
    public class Program
    {
        public static void Main()
        {
            int numOfLines = GetNumOfLines();
            B18_Ex01_02.Program.PrintHourGlass(numOfLines);
            Console.ReadLine();
        }

        private static int GetNumOfLines()
        {
            int numOfLines;

            Console.WriteLine("Please enter the height number of your HourGlass !");
            while (!int.TryParse(Console.ReadLine(), out numOfLines))
            {
                Console.WriteLine("Your input is illegal, please enter a number");
            }

            numOfLines = (numOfLines % 2 == 0) ? numOfLines + 1 : numOfLines;

            return numOfLines;
        }
    }
}
