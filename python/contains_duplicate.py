from typing import List


"""
Example 1:

Input: nums = [1,2,3,1]
Output: true


Example 2:

Input: nums = [1,2,3,4]
Output: false


Example 3:

Input: nums = [1,1,1,3,3,4,3,2,4,2]
Output: true
"""


class Solution:
    def containsDuplicate(self, nums: List[int]) -> bool:
        uniqueNums: set = set()
        for num in nums:
            if num in uniqueNums:
                return True
            uniqueNums.add(num)
        return False


sol: Solution = Solution()
print(f"Expected: True -> Actual: {sol.containsDuplicate(nums = [1,2,3,1])}")
print(f"Expected: False -> Actual: {sol.containsDuplicate(nums = [1,2,3,4])}")
print(
    f"Expected: True -> Actual: {sol.containsDuplicate(nums = [1,1,1,3,3,4,3,2,4,2])}"
)
