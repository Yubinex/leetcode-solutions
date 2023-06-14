/**
 * @param {number[]} nums
 * @return {number[]}
 */
const productExceptSelf = function (nums) {
  const result = [];

  let product = 1;
  for (let i = 0; i < nums.length; ++i) {
    result[i] = product;
    product *= nums[i];
  }

  product = 1;
  for (let j = nums.length - 1; j >= 0; --j) {
    result[j] *= product;
    product *= nums[j];
  }

  return result;
};

/*
Example 1:

Input: nums = [1,2,3,4]
Output: [24,12,8,6]

Example 2:

Input: nums = [-1,1,0,-3,3]
Output: [0,0,9,0,0]
 */

console.log(productExceptSelf([1, 2, 3, 4]));
console.log(productExceptSelf([-1, 1, 0, -3, 3]));
