/**
 * @param {string[]} strs
 * @return {string[][]}
 */
const groupAnagrams = function (strs) {
  const map = new Map();
  for (let i = 0; i < strs.length; ++i) {
    const sortedStr = strs[i].split('').sort().join('');
    if (map.has(sortedStr)) {
      map.get(sortedStr).push(strs[i]);
    } else {
      map.set(sortedStr, [strs[i]]);
    }
  }
  return Array.from(map.values());
};

/*
Example 1:

Input: strs = ["eat","tea","tan","ate","nat","bat"]
Output: [["bat"],["nat","tan"],["ate","eat","tea"]]
Example 2:

Input: strs = [""]
Output: [[""]]
Example 3:

Input: strs = ["a"]
Output: [["a"]]
*/

console.log(groupAnagrams(['eat', 'tea', 'tan', 'ate', 'nat', 'bat']));
console.log(groupAnagrams(['']));
console.log(groupAnagrams(['a']));
