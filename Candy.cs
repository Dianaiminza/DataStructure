using System;

public class Solution {
    public int Candy(int[] ratings) {
        int n = ratings.Length;
        if (n == 0) return 0;
        
        int[] candies = new int[n];
        
        // Step 1: Initialize all candies to 1
        for (int i = 0; i < n; i++) {
            candies[i] = 1;
        }
        
        // Step 2: Left to Right pass
        for (int i = 1; i < n; i++) {
            if (ratings[i] > ratings[i - 1]) {
                candies[i] = candies[i - 1] + 1;
            }
        }
        
        // Step 3: Right to Left pass
        for (int i = n - 2; i >= 0; i--) {
            if (ratings[i] > ratings[i + 1]) {
                candies[i] = Math.Max(candies[i], candies[i + 1] + 1);
            }
        }
        
        // Step 4: Sum up all candies
        int totalCandies = 0;
        for (int i = 0; i < n; i++) {
            totalCandies += candies[i];
        }
        
        return totalCandies;
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();
        
        int[] ratings1 = {1, 0, 2};
        Console.WriteLine(solution.Candy(ratings1)); // Output: 5

        int[] ratings2 = {1, 2, 2};
        Console.WriteLine(solution.Candy(ratings2)); // Output: 4
    }
}
