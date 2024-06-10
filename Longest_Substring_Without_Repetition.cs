using System;
using System.Collections.Generic;

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if (string.IsNullOrEmpty(s)) return 0;

        Dictionary<char, int> charMap = new Dictionary<char, int>();
        int maxLength = 0;
        int start = 0;

        for (int end = 0; end < s.Length; end++) {
            char currentChar = s[end];

            if (charMap.ContainsKey(currentChar)) {
                // Move start to the right of the previous occurrence of the character
                start = Math.Max(start, charMap[currentChar] + 1);
            }

            // Update the character's position in the map
            charMap[currentChar] = end;

            // Calculate the maximum length
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();
        
        Console.WriteLine(solution.LengthOfLongestSubstring("abcabcbb")); // Output: 3
        Console.WriteLine(solution.LengthOfLongestSubstring("bbbbb"));    // Output: 1
        Console.WriteLine(solution.LengthOfLongestSubstring("pwwkew"));   // Output: 3
    }
}
