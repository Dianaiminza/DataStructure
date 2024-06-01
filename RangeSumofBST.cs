public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution {
    public int RangeSumBST(TreeNode root, int low, int high) {
        if (root == null) return 0;

        int sum = 0;

        if (root.val >= low && root.val <= high) {
            sum += root.val;
        }

        if (root.val > low) {
            sum += RangeSumBST(root.left, low, high);
        }

        if (root.val < high) {
            sum += RangeSumBST(root.right, low, high);
        }

        return sum;
    }
}

// Example usage
public class Program {
    public static void Main() {
        Solution solution = new Solution();
        
        // Example 1
        TreeNode root1 = new TreeNode(10);
        root1.left = new TreeNode(5);
        root1.right = new TreeNode(15);
        root1.left.left = new TreeNode(3);
        root1.left.right = new TreeNode(7);
        root1.right.right = new TreeNode(18);
        int low1 = 7, high1 = 15;
        Console.WriteLine(solution.RangeSumBST(root1, low1, high1)); // Output: 32
        
        // Example 2
        TreeNode root2 = new TreeNode(10);
        root2.left = new TreeNode(5);
        root2.right = new TreeNode(15);
        root2.left.left = new TreeNode(3);
        root2.left.right = new TreeNode(7);
        root2.right.left = new TreeNode(13);
        root2.right.right = new TreeNode(18);
        int low2 = 6, high2 = 10;
        Console.WriteLine(solution.RangeSumBST(root2, low2, high2)); // Output: 23
    }
}
