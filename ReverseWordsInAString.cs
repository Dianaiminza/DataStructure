using System;

public class ReverseWords
{
    public string ReverseWordsInString(string s)
    {
        // Trim the input string to remove leading and trailing spaces
        s = s.Trim();
        
        // Split the string by spaces into words and filter out any empty entries
        string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        
        // Reverse the array of words
        Array.Reverse(words);
        
        // Join the words with a single space
        return string.Join(" ", words);
    }
}

public class Program
{
    public static void Main()
    {
        ReverseWords solution = new ReverseWords();

        string s1 = "the sky is blue";
        Console.WriteLine("Reversed: \"" + solution.ReverseWordsInString(s1) + "\""); // Output: "blue is sky the"

        string s2 = "  hello world  ";
        Console.WriteLine("Reversed: \"" + solution.ReverseWordsInString(s2) + "\""); // Output: "world hello"

        string s3 = "a good   example";
        Console.WriteLine("Reversed: \"" + solution.ReverseWordsInString(s3) + "\""); // Output: "example good a"
    }
}
