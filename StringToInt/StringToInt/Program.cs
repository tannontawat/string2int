using System;
using static System.Char;

namespace StringToInt
{
    public class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Please enter value >> ");
                var originalString = Console.ReadLine();

                if (!string.IsNullOrEmpty(originalString))
                {
                    var num = 0;
                    foreach (var character in originalString)
                    {
                        if (IsDigit(character))
                        {
                            // From ASCII value of '0' is 48.
                            // I multiple with 10 for push the digit to next index.
                            num = num * 10 + (character - 48);
                        }
                    }
                    Console.WriteLine(num != 0 ? $"The number is {num}" : "Not have any number.");
                    Console.WriteLine("Thank you");
                    return;
                }
            }
        }
    }
}