public class Solution {
    public int FindMin(int[] nums) {
        if (nums.Length == 1 || nums[0] < nums[nums.Length - 1]) return nums[0];

        int l = 0;
        int r = nums.Length - 1;
        int m = 1;

        while (l < r) {
            m = l + (r - l) / 2;
            if (nums[r] <= nums[m]) l = m + 1;
            else r = m;
        }

        return nums[l];
    }
}
