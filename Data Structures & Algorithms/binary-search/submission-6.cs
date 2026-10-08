public class Solution {
    public int Search(int[] nums, int target) {
        int l = 0;
        int r = nums.Length - 1;
        int needle = (r - l) / 2;
        
        while (true) {
            if (nums[needle] == target) return needle;
            if (r - l < 1) break;

            if (nums[needle] < target) l = needle + 1;
            else if (nums[needle] > target) r = needle - 1;

            needle = l + (r - l) / 2;
        }

        return -1;
    }
}
