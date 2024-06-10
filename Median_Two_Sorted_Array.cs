using System;

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // Ensure nums1 is the smaller array
        if (nums1.Length > nums2.Length) {
            return FindMedianSortedArrays(nums2, nums1);
        }

        int m = nums1.Length;
        int n = nums2.Length;
        int total = m + n;
        int half = (total + 1) / 2;

        int left = 0;
        int right = m;

        while (left <= right) {
            int i = (left + right) / 2;
            int j = half - i;

            int nums1LeftMax = (i == 0) ? int.MinValue : nums1[i - 1];
            int nums1RightMin = (i == m) ? int.MaxValue : nums1[i];
            int nums2LeftMax = (j == 0) ? int.MinValue : nums2[j - 1];
            int nums2RightMin = (j == n) ? int.MaxValue : nums2[j];

            if (nums1LeftMax <= nums2RightMin && nums2LeftMax <= nums1RightMin) {
                // Found the correct partition
                if (total % 2 == 0) {
                    return (Math.Max(nums1LeftMax, nums2LeftMax) + Math.Min(nums1RightMin, nums2RightMin)) / 2.0;
                } else {
                    return Math.Max(nums1LeftMax, nums2LeftMax);
                }
            } else if (nums1LeftMax > nums2RightMin) {
                // Move partition to the left
                right = i - 1;
            } else {
                // Move partition to the right
                left = i + 1;
            }
        }

        throw new ArgumentException("Input arrays are not sorted.");
    }
}

class Program {
    static void Main() {
        Solution solution = new Solution();
        
        int[] nums1 = {1, 3};
        int[] nums2 = {2};
        Console.WriteLine(solution.FindMedianSortedArrays(nums1, nums2)); // Output: 2.0

        int[] nums1_2 = {1, 2};
        int[] nums2_2 = {3, 4};
        Console.WriteLine(solution.FindMedianSortedArrays(nums1_2, nums2_2)); // Output: 2.5
    }
}
