using System;

public class Solution {
    public int Reverse(int x) {
        int reversed = 0;
        
        while (x != 0) {
            int pop = x % 10;
            x /= 10;
            
            // Check for overflow
            if (reversed > Int32.MaxValue/10 || (reversed == Int32.MaxValue / 10 && pop > 7)) return 0;
            if (reversed < Int32.MinValue/10 || (reversed == Int32.MinValue / 10 && pop < -8)) return 0;
            
            reversed = reversed * 10 + pop;
        }
        
        return reversed;
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();
        
        int x
