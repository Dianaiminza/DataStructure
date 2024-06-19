using System;

public class LastWordLength
{
    public int LengthOfLastWord(string s)
    {
        // Trim any trailing spaces
        s = s.Trim();
        
        // Start from the end of the string and find the length of the last word
        int length = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] == ' ')
            {
                break;
            }
            length++;
        }

        return length;
    }
}

public class Program
{
    public static void Main()
    {
        LastWordLength solution = new LastWordLength();
        
        string s1 = "Hello World";
        Console.WriteLine("The length of the last word is: " + solution.LengthOfLastWord(s1)); // Output: 5

        string s2 = "   fly me   to   the moon  ";
        Console.WriteLine("The length of the last word is: " + solution.LengthOfLastWord(s2)); // Output: 4

        string s3 = "luffy is still joyboy";
        Console.WriteLine("The length of the last word is: " + solution.LengthOfLastWord(s3)); // Output: 6
    }
}
