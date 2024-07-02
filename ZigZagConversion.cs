using System;
using System.Text;

public class Solution {
    public string Convert(string s, int numRows) {
        if (numRows == 1) return s; // If numRows is 1, return the original string
        
        StringBuilder[] rows = new StringBuilder[Math.Min(numRows, s.Length)];
        for (int i = 0; i < rows.Length; i++) {
            rows[i] = new StringBuilder();
        }
        
        int currentRow = 0;
        bool goingDown = false;
        
        foreach (char c in s) {
            rows[currentRow].Append(c);
            if (currentRow == 0 || currentRow == numRows - 1) {
                goingDown = !goingDown;
            }
            currentRow += goingDown ? 1 : -1;
        }
        
        StringBuilder result = new StringBuilder();
        foreach (StringBuilder row in rows) {
            result.Append(row);
        }
        
        return result.ToString();
    }
    
    public static void Main(string[] args) {
        Solution sol = new Solution();
        
        string s = "PAYPALISHIRING";
        int numRows = 3;
        Console.WriteLine(sol.Convert(s, numRows)); // Output: "PAHNAPLSIIGYIR"
        
        s = "PAYPALISHIRING";
        numRows = 4;
        Console.WriteLine(sol.Convert(s, numRows)); // Output: "PINALSIGYAHRPI"
        
        s = "A";
        numRows = 1;
        Console.WriteLine(sol.Convert(s, numRows)); // Output: "A"
    }
}
