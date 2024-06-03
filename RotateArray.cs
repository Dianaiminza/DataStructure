public class Solution {
    public void Rotate(int[] nums, int k) {
        int n = nums.Length;
        k = k % n; // Normalize k
        
        Reverse(nums, 0, n - 1);    // Step 1: Reverse the entire array
        Reverse(nums, 0, k - 1);    // Step 2: Reverse the first k elements
        Reverse(nums, k, n - 1);    // Step 3: Reverse the remaining elements
    }
    
    private void Reverse(int[] nums, int start, int end) {
        while (start < end) {
            int temp = nums[start];
            nums[start] = nums[end];
            nums[end] = temp;
            start++;
            end--;
        }
    }
}

// Example usage
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        int[] nums1 = {1, 2, 3, 4, 5, 6, 7};
        int k1 = 3;
        solution.Rotate(nums1, k1);
        Console.WriteLine(string.Join(", ", nums1)); // Output: [5, 6, 7, 1, 2, 3, 4]
        
        int[] nums2 = {-1, -100, 3, 99};
        int k2 = 2;
        solution.Rotate(nums2, k2);
        Console.WriteLine(string.Join(", ", nums2)); // Output: [3, 99, -1, -100]
    }
}
