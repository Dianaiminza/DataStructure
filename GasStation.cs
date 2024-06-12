using System;

public class Solution {
    public int CanCompleteCircuit(int[] gas, int[] cost) {
        int totalSurplus = 0;
        int currentSurplus = 0;
        int startIndex = 0;

        for (int i = 0; i < gas.Length; i++) {
            int balance = gas[i] - cost[i];
            totalSurplus += balance;
            currentSurplus += balance;

            // If currentSurplus drops below zero, reset start index and currentSurplus
            if (currentSurplus < 0) {
                startIndex = i + 1;
                currentSurplus = 0;
            }
        }

        // If the total surplus is negative, return -1 as it's not possible to complete the circuit
        return totalSurplus >= 0 ? startIndex : -1;
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();

        int[] gas1 = {1, 2, 3, 4, 5};
        int[] cost1 = {3, 4, 5, 1, 2};
        Console.WriteLine(solution.CanCompleteCircuit(gas1, cost1)); // Output: 3

        int[] gas2 = {2, 3, 4};
        int[] cost2 = {3, 4, 3};
        Console.WriteLine(solution.CanCompleteCircuit(gas2, cost2)); // Output: -1
    }
}
