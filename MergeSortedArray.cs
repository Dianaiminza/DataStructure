public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int p1 = m - 1;  // pointer for the end of the non-zero part of nums1
        int p2 = n - 1;  // pointer for the end of nums2
        int p = m + n - 1;  // pointer for the end of nums1 (the part that includes the extra space)

        // While there are elements to compare in both arrays
        while (p1 >= 0 && p2 >= 0) {
            if (nums1[p1] > nums2[p2]) {
                nums1[p] = nums1[p1];
                p1--;
            } else {
                nums1[p] = nums2[p2];
                p2--;
            }
            p--;
        }

        // If there are remaining elements in nums2, add them to nums1
        while (p2 >= 0) {
            nums1[p] = nums2[p2];
            p2--;
            p--;
        }
    }
}

// Example usage:
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        int[] nums1 = {1, 2, 3, 0, 0, 0};
        int m = 3;
        int[] nums2 = {2, 5, 6};
        int n = 3;
        solution.Merge(nums1, m, nums2, n);
        Console.WriteLine(string.Join(", ", nums1)); // Output: [1, 2, 2, 3, 5, 6]

        int[] nums3 = {1};
        int m3 = 1;
        int[] nums4 = {};
        int n3 = 0;
        solution.Merge(nums3, m3, nums4, n3);
        Console.WriteLine(string.Join(", ", nums3)); // Output: [1]

        int[] nums5 = {0};
        int m5 = 0;
        int[] nums6 = {1};
        int n5 = 1;
        solution.Merge(nums5, m5, nums6, n5);
        Console.WriteLine(string.Join(", ", nums5)); // Output: [1]
    }
}
