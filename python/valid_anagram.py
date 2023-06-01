from typing import Dict

"""
Example 1:

Input: s = "anagram", t = "nagaram"
Output: true


Example 2:

Input: s = "rat", t = "car"
Output: false
"""


class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        chars_s: Dict[str, int] = dict()
        chars_t: Dict[str, int] = dict()
        for c in s:
            if c in chars_s:
                chars_s[c] += 1
            else:
                chars_s[c] = 1
        for c in t:
            if c in chars_t:
                chars_t[c] += 1
            else:
                chars_t[c] = 1
        return chars_s == chars_t


sol = Solution()
print(f"{sol.isAnagram('anagram', 'nagaram')}")
print(f"{sol.isAnagram('rat', 'car')}")
