using System;

public class LongestCommonPrefix
{
    public string FindLongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
        {
            return "";
        }

        // Initialize the prefix to be the first string in the array
        string prefix = strs[0];

        // Iterate over the rest of the strings
        for (int i = 1; i < strs.Length; i++)
        {
            // Adjust the prefix length while it does not match the beginning of strs[i]
            while (strs[i].IndexOf(prefix) != 0)
            {
                prefix = prefix.Substring(0, prefix.Length - 1);
                if (prefix.Length == 0)
                {
                    return "";
                }
            }
        }

        return prefix;
    }
}

public class Program
{
    public static void Main()
    {
        LongestCommonPrefix solution = new LongestCommonPrefix();

        string[] strs1 = { "flower", "flow", "flight" };
        Console.WriteLine("Longest common prefix: " + solution.FindLongestCommonPrefix(strs1)); // Output: "fl"

        string[] strs2 = { "dog", "racecar", "car" };
        Console.WriteLine("Longest common prefix: " + solution.FindLongestCommonPrefix(strs2)); // Output: ""

        string[] strs3 = { "interview", "intermediate", "internal", "internet" };
        Console.WriteLine("Longest common prefix: " + solution.FindLongestCommonPrefix(strs3)); // Output: "inter"
    }
}
