using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex01_02
{
    public class Program
    {
        public static void Main()
        {
            PrintHourGlass(5);
            Console.ReadLine();
        }

        // method is public so i can use it in ex3
        public static void PrintHourGlass(int i_NumOfLines)
        {
            StringBuilder hourglass = new StringBuilder(string.Empty);
            buildTop(hourglass, i_NumOfLines);
            buildBottom(hourglass, i_NumOfLines);

            Console.WriteLine(hourglass);
        }

        private static void buildTop(StringBuilder i_hourglass, int i_NumOfLines)
        {
            int row = 0;

            for (int i = i_NumOfLines; i > 0; i -= 2)
            {
                for (int j = 0; j < i; j++)
                {
                    i_hourglass.Append("*");
                }

                i_hourglass.Append(Environment.NewLine);
                if (i > 1)
                {
                    row++;
                    for (int k = 0; k < row; k++)
                    {
                        i_hourglass.Append(" ");
                    }
                }
                else
                {
                    row--;
                    for (int k = 0; k < row; k++)
                    {
                        i_hourglass.Append(" ");
                    }
                }
            }
        }

        private static void buildBottom(StringBuilder i_HourGlass, int i_NumOfLines)
        {
            int row = (i_NumOfLines - 3) / 2;
            for (int i = 3; i <= i_NumOfLines; i += 2)
            {
                for (int j = 0; j < i; j++)
                {
                    i_HourGlass.Append("*");
                }

                i_HourGlass.Append(Environment.NewLine);
                row--;
                if (i <= i_NumOfLines)
                {
                    for (int k = 0; k < row; k++)
                    {
                        i_HourGlass.Append(" ");
                    }
                }
            }
        }
    }
}
