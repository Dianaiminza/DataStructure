public class Solution {
    public int RemoveElement(int[] nums, int val) {
        int k = 0; // Pointer for the position of the next element not equal to val
        
        // Iterate through the array
        for (int i = 0; i < nums.Length; i++) {
            // If the current element is not equal to val
            if (nums[i] != val) {
                // Place it at the kth position
                nums[k] = nums[i];
                // Move the pointer forward
                k++;
            }
        }
        
        // Return the number of elements not equal to val
        return k;
    }
}

// Example usage
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        int[] nums1 = {3, 2, 2, 3};
        int val1 = 3;
        int k1 = solution.RemoveElement(nums1, val1);
        Console.WriteLine(k1); // Output: 2
        Console.WriteLine(string.Join(", ", nums1)); // Output: 2, 2, _, _
        
        int[] nums2 = {0, 1, 2, 2, 3, 0, 4, 2};
        int val2 = 2;
        int k2 = solution.RemoveElement(nums2, val2);
        Console.WriteLine(k2); // Output: 5
        Console.WriteLine(string.Join(", ", nums2)); // Output: 0, 1, 3, 0, 4, _, _, _
    }
}
