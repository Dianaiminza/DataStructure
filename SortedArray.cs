public class Solution {
    public int RemoveDuplicates(int[] nums) {
        if (nums.Length == 0) return 0;

        int write_index = 1; // Start from the second position

        for (int read_index = 1; read_index < nums.Length; read_index++) {
            if (nums[read_index] != nums[read_index - 1]) {
                nums[write_index] = nums[read_index];
                write_index++;
            }
        }

        return write_index;
    }
}

// Example usage
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        int[] nums1 = {1, 1, 2};
        int k1 = solution.RemoveDuplicates(nums1);
        Console.WriteLine(k1); // Output: 2
        Console.WriteLine(string.Join(", ", nums1, 0, k1)); // Output: 1, 2

        int[] nums2 = {0, 0, 1, 1, 1, 2, 2, 3, 3, 4};
        int k2 = solution.RemoveDuplicates(nums2);
        Console.WriteLine(k2); // Output: 5
        Console.WriteLine(string.Join(", ", nums2, 0, k2)); // Output: 0, 1, 2, 3, 4
    }
}
