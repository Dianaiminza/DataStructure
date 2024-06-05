public class Solution {
    public int Jump(int[] nums) {
        int jumps = 0;
        int currentJumpEnd = 0;
        int farthestJump = 0;
        
        for (int i = 0; i < nums.Length - 1; i++) {
            farthestJump = Math.Max(farthestJump, i + nums[i]);
            
            if (i == currentJumpEnd) {
                jumps++;
                currentJumpEnd = farthestJump;
            }
        }
        
        return jumps;
    }
}
