using System;

public class IntToRomanConverter
{
    public string IntToRoman(int num)
    {
        // Define arrays of the Roman numeral symbols and their corresponding values
        string[] symbols = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
        int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };

        // Initialize the result string
        string result = string.Empty;

        // Iterate over the values and symbols arrays
        for (int i = 0; i < values.Length && num > 0; i++)
        {
            // Append the corresponding symbols as long as the value can be subtracted from num
            while (num >= values[i])
            {
                result += symbols[i];
                num -= values[i];
            }
        }

        return result;
    }
}

public class Program
{
    public static void Main()
    {
        IntToRomanConverter converter = new IntToRomanConverter();
        int number = 1994; // Example: 1994
        string result = converter.IntToRoman(number);
        Console.WriteLine("The Roman numeral of " + number + " is " + result); // Output: MCMXCIV
    }
}
