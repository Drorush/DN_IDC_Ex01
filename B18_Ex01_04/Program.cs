using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B18_Ex01_04
{
    public class Program
    {
        public static void Main()
        {
            int num;

            string input = GetInput();
            CheckIfPalindrome(input);
            if (int.TryParse(input, out num))
            {
                IsEven(num);
            }
            else
            {
                LowerCaseCounter(input);
            }

            Console.ReadLine();
        }

        private static void LowerCaseCounter(string i_input)
        {
            int count = 0;

            for (int i = 0; i < i_input.Length; i++)
            {
                if (char.IsLower(i_input[i]))
                {
                    count++;
                }
            }

            Console.WriteLine("The string contains " + count + " lower case letters");
        }

        private static void IsEven(int i_num)
        {
            if (i_num % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The number is odd");
            }
        }

        private static void CheckIfPalindrome(string i_input)
        {
            if (IsPalindrome(i_input))
            { 
                Console.WriteLine("the string is palindrome");
            }
            else
            {
                Console.WriteLine("the string isn't palindrome");
            }
        }

        private static Boolean IsPalindrome(string i_input)
        {
            bool isPalindrome = true;
            int startIndex = 0;
            int endIndex = i_input.Length - 1;

            while (isPalindrome && (startIndex <= endIndex))
            {
                isPalindrome = i_input[startIndex] == i_input[endIndex];
                startIndex++;
                endIndex--;
            }

            return isPalindrome;
        }

        private static string GetInput()
        {
            bool isLegal = false;
            string input = string.Empty;
            Console.WriteLine("Please enter a string of length 8 (contains only letters or numbers) and then press enter");
            while (!isLegal)
            {
                input = Console.ReadLine();
                isLegal = IsLegal(input);
                if (!isLegal)
                {
                    Console.WriteLine("Your input is illegal, please try again");
                }
            }

            return input;
        }

        private static Boolean IsLegal(string i_input)
        {
            bool isLegalLength = i_input.Length == 8;
            bool isNumeric = int.TryParse(i_input, out int n);
            bool isAlphaBet = i_input.All(char.IsLetter);

            return isLegalLength && (isNumeric || isAlphaBet);
        }
    }
}
