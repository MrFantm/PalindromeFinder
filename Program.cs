using System;
using System.Text.RegularExpressions;

namespace PalindromFinder {
    class Program {
        public static void Main(string[] args) 
        {
            Console.WriteLine("Enter a string of text: ");
            string input = Console.ReadLine();

            if(IsPalindrome(input)) 
            {
                Console.WriteLine("Palindrome");
            }
            else 
            {
                Console.WriteLine("Not a Palindrome");
            }

            Console.ReadLine();
        }

        public static bool IsPalindrome(string input) 
        {
            string cleanedInput = Regex.Replace(input, "[^a-zA-Z0-9]", "").ToLower();
            char[] text = cleanedInput.ToCharArray();
            Array.Reverse(text);

            string reverse = new string(text);
            return reverse == cleanedInput;
        }
    }
}
