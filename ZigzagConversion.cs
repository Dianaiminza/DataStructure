using System;
using System.Text;

public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1 || s.Length <= numRows) return s;

        // Create an array of StringBuilders for each row
        StringBuilder[] rows = new StringBuilder[Math.Min(numRows, s.Length)];
        for (int i = 0; i < rows.Length; i++) {
            rows[i] = new StringBuilder();
        }

        int currentRow = 0;
        bool goingDown = false;

        // Traverse the input string and place characters in the appropriate row
        foreach (char c in s) {
            rows[currentRow].Append(c);
            if (currentRow == 0 || currentRow == numRows - 1) {
                goingDown = !goingDown; // Change direction at the first and last row
            }
            currentRow += goingDown ? 1 : -1;
        }

        // Combine all rows into one string
        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows) {
            result.Append(row);
        }

        return result.ToString();
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();

        string s1 = "PAYPALISHIRING";
        int numRows1 = 3;
        Console.WriteLine(solution.Convert(s1, numRows1)); // Output: "PAHNAPLSIIGYIR"

        string s2 = "PAYPALISHIRING";
        int numRows2 = 4;
        Console.WriteLine(solution.Convert(s2, numRows2)); // Output: "PINALSIGYAHRPI"

        string s3 = "A";
        int numRows3 = 1;
        Console.WriteLine(solution.Convert(s3, numRows3)); // Output: "A"
    }
}
