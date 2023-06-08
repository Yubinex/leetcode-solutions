/**
 * @param {string} s
 * @param {string} t
 * @return {boolean}
 */
const isAnagram = function (s, t) {
  return s.split('').sort().join('') === t.split('').sort().join('');
};

/*
Example 1:

Input: s = "anagram", t = "nagaram"
Output: true

Example 2:

Input: s = "rat", t = "car"
Output: false
*/

console.log(isAnagram('anagram', 'nagaram'));
console.log(isAnagram('rat', 'car'));
