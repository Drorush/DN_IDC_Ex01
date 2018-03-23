using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex01_05
{
    public class Program
    {
        public static void Main()
        {
            int input = GetPositiveIntegerFromUser();
            GetMaxAndMinDigits(input);
            CountEvens(input);
            CountDigitsLowerThanOnesDigit(input);
            Console.ReadLine();
        }

        private static void CountDigitsLowerThanOnesDigit(int i_num)
        {
            int count = 0;
            int onesDigit = i_num % 10;
            i_num /= 10;

            for (int i = 0; i < 5; i++)
            {
                if (i_num % 10 < onesDigit)
                {
                    count++;
                }

                i_num /= 10;
            }

            Console.WriteLine(count + " Of the numbers are lower than the ones digit");
        }

        private static int GetMin(int i_num)
        {
            int minDigit = int.MaxValue;
            int singleDigit = 0;

            for (int i = 0; i < 6; i++)
            {
                singleDigit = i_num % 10;

                if (singleDigit % 10 < minDigit)
                {
                    minDigit = singleDigit;
                }

                i_num /= 10;
            }

            return minDigit;
        }

        private static void CountEvens(int i_num)
        {
            int count = 0;

            for (int i = 0; i < 6; i++)
            {
                if ((i_num % 10) % 2 == 0)
                {
                    count++;
                }

                i_num /= 10;
            }

            Console.WriteLine(count + " Of the digits are even");
        }

        private static void GetMaxAndMinDigits(int i_num)
        {
            int maxDigit = int.MinValue;
            int originalNum = i_num;
            int minDigit;
            int singleDigit = 0;

            for (int i = 0; i < 6; i++)
            {
                singleDigit = i_num % 10;
                if (singleDigit > maxDigit)
                {
                    maxDigit = singleDigit;
                }

                i_num /= 10;
            }

            minDigit = GetMin(originalNum);
            Console.WriteLine("The maximum digit is " + maxDigit);
            Console.WriteLine("The minimum digit is " + minDigit);
        }

        private static int GetPositiveIntegerFromUser()
        {
            bool isLegal = false;
            string input;
            int num = 0;

            Console.WriteLine("please enter 6 digit positive integer, and then press enter");
            while (!isLegal)
            {
                input = Console.ReadLine();
                isLegal = int.TryParse(input, out num) && num > 0;
                if (!isLegal)
                {
                    Console.WriteLine("Your input is illegal, please try again");
                }
            }

            Console.WriteLine("The number is: " + num);
            return num;
        }
    }
}
