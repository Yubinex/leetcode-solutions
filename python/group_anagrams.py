from typing import List, Dict


"""
Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]

Example 2:

Input: strs = [""]
Output: [[""]]

Example 3:

Input: strs = ["a"]
Output: [["a"]]
"""


class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        anagram_groups: Dict[str, List[str]] = {}

        for word in strs:
            chars: List[str] = [c for c in word]
            chars.sort()
            sorted_word: str = ''.join(chars)

            if sorted_word not in anagram_groups:
                anagram_groups[sorted_word] = []
            anagram_groups[sorted_word].append(word)

        return [x for x in anagram_groups.values()]


sol: Solution = Solution()
print(sol.groupAnagrams(["eat","tea","tan","ate","nat","bat"]))
print(sol.groupAnagrams([""]))
print(sol.groupAnagrams(["a"]))