using System;

public class WaterTrap
{
    public int Trap(int[] height)
    {
        if (height == null || height.Length == 0)
        {
            return 0;
        }

        int left = 0;
        int right = height.Length - 1;
        int leftMax = 0;
        int rightMax = 0;
        int waterTrapped = 0;

        while (left < right)
        {
            if (height[left] < height[right])
            {
                if (height[left] >= leftMax)
                {
                    leftMax = height[left];
                }
                else
                {
                    waterTrapped += leftMax - height[left];
                }
                left++;
            }
            else
            {
                if (height[right] >= rightMax)
                {
                    rightMax = height[right];
                }
                else
                {
                    waterTrapped += rightMax - height[right];
                }
                right--;
            }
        }

        return waterTrapped;
    }
}

public class Program
{
    public static void Main()
    {
        WaterTrap solution = new WaterTrap();
        int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
        int result = solution.Trap(height);
        Console.WriteLine("Water trapped: " + result); // Output: 6
    }
}
