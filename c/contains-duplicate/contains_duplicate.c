#include <stdbool.h>
#include <stdio.h>

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

bool containsDuplicate(int* nums, int numsSize);

int main() {
    int nums1[] = {1, 2, 3, 1};
    int nums1Size = sizeof(nums1) / sizeof(nums1[0]);
    printf("%s", containsDuplicate(nums1, nums1Size) ? "true" : "false");
    printf("\n");
    int nums2[] = {1, 2, 3, 4};
    int nums2Size = sizeof(nums2) / sizeof(nums2[0]);
    printf("%s", containsDuplicate(nums2, nums2Size) ? "true" : "false");
    printf("\n");
    int nums3[] = {1, 1, 1, 3, 3, 4, 3, 2, 4, 2};
    int nums3Size = sizeof(nums3) / sizeof(nums3[0]);
    printf("%s", containsDuplicate(nums3, nums3Size) ? "true" : "false");
    printf("\n");
    return 0;
}

bool containsDuplicate(int* nums, int numsSize) {
    for (int i = 0; i < numsSize; ++i) {
        int tmp = nums[i];
        for (int j = i + 1; j < numsSize; ++j) {
            if (tmp == nums[j]) {
                return true;
            }
        }
    }
    return false;
}