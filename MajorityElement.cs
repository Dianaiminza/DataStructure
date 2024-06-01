public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = nums[0];
        int count = 1;

        for (int i = 1; i < nums.Length; i++) {
            if (count == 0) {
                candidate = nums[i];
                count = 1;
            } else if (nums[i] == candidate) {
                count++;
            } else {
                count--;
            }
        }

        return candidate;
    }
}

// Example usage
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        int[] nums1 = {3, 2, 3};
        Console.WriteLine(solution.MajorityElement(nums1)); // Output: 3

        int[] nums2 = {2, 2, 1, 1, 1, 2, 2};
        Console.WriteLine(solution.MajorityElement(nums2)); // Output: 2
    }
}
