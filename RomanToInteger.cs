using System;
using System.Collections.Generic;

public class RomanToIntConverter
{
    public int RomanToInt(string s)
    {
        if (string.IsNullOrEmpty(s))
        {
            return 0;
        }

        // Create a dictionary to map Roman numerals to their integer values
        Dictionary<char, int> romanMap = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        int total = 0;
        int prevValue = 0;

        // Iterate through the string in reverse order
        for (int i = s.Length - 1; i >= 0; i--)
        {
            char currentChar = s[i];
            int currentValue = romanMap[currentChar];

            // If the current value is less than the previous value, subtract it
            if (currentValue < prevValue)
            {
                total -= currentValue;
            }
            else
            {
                total += currentValue;
            }

            prevValue = currentValue;
        }

        return total;
    }
}

public class Program
{
    public static void Main()
    {
        RomanToIntConverter converter = new RomanToIntConverter();
        string roman = "MCMXCIV"; // Example: 1994
        int result = converter.RomanToInt(roman);
        Console.WriteLine("The integer value of " + roman + " is " + result); // Output: 1994
    }
}
