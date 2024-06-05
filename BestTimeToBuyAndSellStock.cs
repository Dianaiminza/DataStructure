using System;

public class Solution {
    public int MaxProfit(int[] prices) {
        if (prices.Length == 0)
            return 0;

        int minPrice = prices[0];
        int maxProfit = 0;

        foreach (int price in prices) {
            minPrice = Math.Min(minPrice, price);
            maxProfit = Math.Max(maxProfit, price - minPrice);
        }

        return maxProfit;
    }

    static void Main(string[] args) {
        Solution solution = new Solution();

        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(solution.MaxProfit(prices1));  // Output: 5

        int[] prices2 = { 7, 6, 4, 3, 1 };
        Console.WriteLine(solution.MaxProfit(prices2));  // Output: 0
    }
}
