using Palindrome.Domain;
using System;

namespace Palindromes.Client
{
    public class Program
    {
        public static void Main (string[] args)
        {
            UserView();
        }

        public static void UserView()
        {
            Console.WriteLine("Welcome to PalindromeChecker!",
                "Please type the word or sentence you want checked.",
                "Or, to quit, type 'exit' (exit is not a palindrome, by the way).");
            string s = Console.ReadLine();
            if (s.ToLower().Trim() == "exit") {return;}
            PalindromeChecker p = new PalindromeChecker(s);
            if (p.palindrome)
            {
                Console.WriteLine(s+" is a palindrome!");
            }
            else
            {
                Console.WriteLine(s+" is NOT a palindrome!");
            }
            UserView();
        }
    }
}