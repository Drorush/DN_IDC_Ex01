using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex01_01
{
    public class Program
    {
        public static void Main()
        {
            int[] binaryNumbers = GetThreeBinaryNumbers();
            int[] decimalNumbers = ConvertBinaryArrayToDecimal(binaryNumbers);
            PrintNumbers(decimalNumbers);
            AvgNumOfOnesAndZeros(NumOfOnes(binaryNumbers));
            PowerOfTwo(NumOfOnes(binaryNumbers));
            NumOfStrictlyDecreasing(decimalNumbers);
            PrintAvg(decimalNumbers);
            Console.ReadLine();
        }

        private static void AvgNumOfOnesAndZeros(int[] i_NumOfOnes)
        {
            int[] numOfOnesAndZeros = new int[2];

            for (int i = 0; i < i_NumOfOnes.Length; i++)
            {
                numOfOnesAndZeros[1] += i_NumOfOnes[i];
                numOfOnesAndZeros[0] += 9 - i_NumOfOnes[i];
            }

            numOfOnesAndZeros[0] /= i_NumOfOnes.Length;
            numOfOnesAndZeros[1] /= i_NumOfOnes.Length;
            string output = string.Format("In average there are {0} number of zeros and {1} number of ones in every number", numOfOnesAndZeros[0], numOfOnesAndZeros[1]);
            Console.WriteLine(output);
        }

        private static void PrintAvg(int[] i_Numbers)
        {
            float sum = 0;
            float avg;

            for (int i = 0; i < i_Numbers.Length; i++)
            {
                sum += i_Numbers[i];
            }

            avg = sum / i_Numbers.Length;
            Console.WriteLine("The average of the numbers is: " + avg);
        }

        // note: i assume that a one digit number is a strictly decreasing number.
        private static void NumOfStrictlyDecreasing(int[] i_Numbers)
        {
            int numOfStrictlyDecreasing = 0;

            for (int i = 0; i < i_Numbers.Length; i++)
            {
                if (IsStrictlyDecreasing(i_Numbers[i]))
                {
                    numOfStrictlyDecreasing++;
                }
            }

            Console.WriteLine(numOfStrictlyDecreasing + " Of the numbers are strictly decreasing");
        }

        private static Boolean IsStrictlyDecreasing(int i_num)
        {
            bool strictlyDecreasing = true;
            int firstNum, secondNum;

            firstNum = i_num % 10;
            i_num /= 10;
            while (strictlyDecreasing && i_num != 0)
            {
                secondNum = i_num % 10;
                strictlyDecreasing = firstNum < secondNum;
                firstNum = secondNum;
                i_num /= 10;
            }

            return strictlyDecreasing;
        }

        private static void PowerOfTwo(int[] i_numOfOnes)
        {
            int countOnes = 0;

            for (int i = 0; i < i_numOfOnes.Length; i++)
            {
                if (i_numOfOnes[i] == 1)
                {
                    countOnes++;
                }
            }

            Console.WriteLine(countOnes + " Of the numbers are power of two");
        }

        private static int[] NumOfOnes(int[] i_binaryNumbers)
        {
            int[] numOfOnes = new int[i_binaryNumbers.Length];

            for (int i = 0; i < numOfOnes.Length; i++)
            {
                numOfOnes[i] = CountOnes(i_binaryNumbers[i]);
            }

            return numOfOnes;
        }

        private static int CountOnes(int i_num)
        {
            int i = 0;
            int numOfOnes = 0;

            while (i_num != 0)
            {
                i = i_num % 10;
                if (i == 1)
                {
                    numOfOnes++;
                }

                i_num /= 10;
            }

            return numOfOnes;
        }

        private static void PrintNumbers(int[] i_Numbers)
        {
            Console.WriteLine("The numbers are:");
            for (int i = 0; i < i_Numbers.Length; i++)
            {
                Console.WriteLine(i_Numbers[i]);
            }
        }

        private static int[] ConvertBinaryArrayToDecimal(int[] i_BinaryNumbers)
        {
            int[] decimals = new int[i_BinaryNumbers.Length];

            for (int i = 0; i < i_BinaryNumbers.Length; i++)
            {
                decimals[i] = BinaryToDecimal(i_BinaryNumbers[i]);
            }

            return decimals;
        }

        private static int BinaryToDecimal(int i_BinaryNumber)
        {
            int decimalNumber = 0;
            int remainder = 0;
            int i = 0;

            while (i_BinaryNumber != 0)
            {
                remainder = i_BinaryNumber % 10;
                i_BinaryNumber /= 10;
                decimalNumber += remainder * (int)Math.Pow(2, i);
                i++;
            }

            return decimalNumber;
        }

        private static int[] GetThreeBinaryNumbers()
        {
            int[] binaryNumbers = new int[3];
            int numOfLegalInputs = 0;
            string input;

            while (numOfLegalInputs < 3)
            {
                Console.WriteLine("Please enter 9 digits binary number (and then press enter)");
                input = Console.ReadLine();
                if (IsLegalInput(input))
                {
                    binaryNumbers[numOfLegalInputs] = int.Parse(input);
                    numOfLegalInputs++;
                }
                else
                {
                    Console.WriteLine("Your input is illegal !");
                }
            }

            return binaryNumbers;
        }

        private static bool IsLegalInput(string i_Input)
        {
            bool isLegalInput = i_Input.Length == 9;
            int i = 0;

            while (isLegalInput && i < i_Input.Length)
            {
                if (i_Input[i] != '0' && i_Input[i] != '1')
                {
                    isLegalInput = false;
                }

                i++;
            }

            return isLegalInput;
        }
    }
}
