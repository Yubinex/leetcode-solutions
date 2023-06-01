namespace TwoSum;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] example1 = sol.TwoSum(new[] { 2, 7, 11, 15 }, 9);
        int[] example2 = sol.TwoSum(new[] { 3, 2, 4 }, 6);
        int[] example3 = sol.TwoSum(new[] { 3, 3 }, 6);
        Console.WriteLine($"Expected: [0,1] -> Actual: [{example1[0]},{example1[1]}]");
        Console.WriteLine($"Expected: [1,2] -> Actual: [{example2[0]},{example2[1]}]");
        Console.WriteLine($"Expected: [0,1] -> Actual: [{example3[0]},{example3[1]}]");
    }
}

/*
Example 1:

Input: nums = [2,7,11,15], target = 9
Output: [0,1]
Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].


Example 2:

Input: nums = [3,2,4], target = 6
Output: [1,2]


Example 3:

Input: nums = [3,3], target = 6
Output: [0,1]
*/
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        int[] result = new int[2];
        for (int i = 0; i < nums.Length; i++)
        {
            int temp = target - nums[i];
            if (nums.Contains(temp) && Array.IndexOf(nums, temp) != i)
            {
                result[0] = i;
                result[1] = Array.IndexOf(nums, temp);
            }
        }
        return result;
    }
}
