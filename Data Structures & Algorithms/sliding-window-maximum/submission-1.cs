public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        var maxes = new int[nums.Length - k + 1];

        int maxIdx = 0;
        for (int i = 1; i < k; i++) {
            if (nums[i] > nums[maxIdx]) maxIdx = i;
        }

        maxes[0] = nums[maxIdx];

        for (int l = 1; l < nums.Length - k + 1; l++) {
            if (maxIdx < l) {
                maxIdx = l;
                for (int i = maxIdx; i < l + k - 1; i++) {
                    if (nums[i] > nums[maxIdx]) maxIdx = i;
                }
            }
            if (nums[l + k - 1] > nums[maxIdx]) maxIdx = l + k - 1;
            maxes[l] = nums[maxIdx];
        }

        return maxes;
    }
}
