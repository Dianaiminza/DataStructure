using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsPalindrome("racecar"));  // true
        Console.WriteLine(IsPalindrome("hello"));    // false
        Console.WriteLine(IsPalindrome("A man, a plan, a canal, Panama"));  // true
    }

    // Function to check if a string is a palindrome
    static bool IsPalindrome(string input)
    {
        // Remove non-alphanumeric characters and convert to lowercase
        var cleanedInput = new string(input
            .Where(c => Char.IsLetterOrDigit(c))
            .Select(c => Char.ToLower(c))
            .ToArray());

        // Check if the cleaned string is the same forwards and backwards
        return cleanedInput == new string(cleanedInput.Reverse().ToArray());
    }
}
