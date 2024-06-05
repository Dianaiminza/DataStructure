public class Solution {
    public int MaxProfit(int[] prices) {
        int maxProfit = 0;
        
        for (int i = 1; i < prices.Length; i++) {
            if (prices[i] > prices[i - 1]) {
                maxProfit += prices[i] - prices[i - 1];
            }
        }
        
        return maxProfit;
    }

    static void Main(string[] args) {
        Solution solution = new Solution();

        int[] prices1 = { 7, 1, 5, 3, 6, 4 };
        Console.WriteLine(solution.MaxProfit(prices1));  // Output: 7

        int[] prices2 = { 1, 2, 3, 4, 5 };
        Console.WriteLine(solution.MaxProfit(prices2));  // Output: 4

        int[] prices3 = { 7, 6, 4, 3, 1 };
        Console.WriteLine(solution.MaxProfit(prices3));  // Output: 0
    }
}
