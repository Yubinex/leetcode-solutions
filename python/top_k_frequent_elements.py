from typing import List

class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        frequencies: dict = {}

        for n in nums:
            if n in frequencies:
                frequencies[n] += 1
            else:
                frequencies[n] = 1

        sorted_keys = sorted(frequencies,key=lambda x: frequencies[x], reverse=True)
        return sorted_keys[:k]

"""
Example 1:

Input: nums = [1,1,1,2,2,3], k = 2
Output: [1,2]

Example 2:

Input: nums = [1], k = 1
Output: [1]
"""

sol: Solution = Solution()
print(sol.topKFrequent([1,1,1,2,2,3], 2))
print(sol.topKFrequent([1], 1))
