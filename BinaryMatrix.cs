using System;
using System.Collections.Generic;

public class Solution {
    public int ShortestPathBinaryMatrix(int[][] grid) {
        int n = grid.Length;
        if (grid[0][0] == 1 || grid[n - 1][n - 1] == 1) return -1; // Check if start or end cell is blocked
        
        int[][] directions = {
            new int[] { -1, -1 }, // top left
            new int[] { -1, 0 }, // top
            new int[] { -1, 1 }, // top right
            new int[] { 0, -1 }, // left
            new int[] { 0, 1 }, // right
            new int[] { 1, -1 }, // bottom left
            new int[] { 1, 0 }, // bottom
            new int[] { 1, 1 } // bottom right
        };

        Queue<int[]> queue = new Queue<int[]>();
        HashSet<string> visited = new HashSet<string>();

        queue.Enqueue(new int[] { 0, 0 });
        visited.Add("0-0");

        int distance = 1;

        while (queue.Count > 0) {
            int size = queue.Count;

            for (int i = 0; i < size; i++) {
                int[] cell = queue.Dequeue();
                int row = cell[0], col = cell[1];

                if (row == n - 1 && col == n - 1) return distance; // Reached the bottom-right cell

                foreach (var dir in directions) {
                    int newRow = row + dir[0], newCol = col + dir[1];
                    if (newRow >= 0 && newRow < n && newCol >= 0 && newCol < n && grid[newRow][newCol] == 0) {
                        string key = newRow + "-" + newCol;
                        if (!visited.Contains(key)) {
                            queue.Enqueue(new int[] { newRow, newCol });
                            visited.Add(key);
                        }
                    }
                }
            }

            distance++;
        }

        return -1; // No clear path found
    }
}

// Example usage
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        int[][] grid1 = {
            new int[] {0, 0, 0},
            new int[] {1, 1, 0},
            new int[] {1, 1, 0}
        };
        Console.WriteLine(solution.ShortestPathBinaryMatrix(grid1)); // Output: 4

        int[][] grid2 = {
            new int[] {0, 1},
            new int[] {1, 0}
        };
        Console.WriteLine(solution.ShortestPathBinaryMatrix(grid2)); // Output: 2
    }
}
