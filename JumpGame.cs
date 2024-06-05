public class Solution {
    public bool CanJump(int[] nums) {
        int furthestReachable = 0;
        
        for (int i = 0; i < nums.Length; i++) {
            if (i > furthestReachable) {
                return false;
            }
            furthestReachable = Math.Max(furthestReachable, i + nums[i]);
        }
        
        return true;
    }

    static void Main(string[] args) {
        Solution solution = new Solution();

        int[] nums1 = { 2, 3, 1, 1, 4 };
        Console.WriteLine(solution.CanJump(nums1));  // Output: True

        int[] nums2 = { 3, 2, 1, 0, 4 };
        Console.WriteLine(solution.CanJump(nums2));  // Output: False
    }
}
