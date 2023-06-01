namespace ContainsDuplicate;

public class Program
{
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine(
            $"Expected: True -> Actual: {sol.ContainsDuplicate(new[] { 1, 2, 3, 1 })}");
        Console.WriteLine(
            $"Expected: False -> Actual: {sol.ContainsDuplicate(new[] { 1, 2, 3, 4 })}");
        Console.WriteLine(
            $"Expected: True -> Actual: {sol.ContainsDuplicate(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })}");
    }
}

/*
Example 1:

Input: nums = [1,2,3,1]
Output: true


Example 2:

Input: nums = [1,2,3,4]
Output: false


Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
*/
public class Solution
{
    public bool ContainsDuplicate(int[] nums)
    {
        HashSet<int> encounteredNums = new HashSet<int>();
        foreach (int num in nums)
        {
            if (encounteredNums.Contains(num)) { return true; }
            encounteredNums.Add(num);
        }
        return false;
    }
}
