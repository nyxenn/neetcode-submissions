public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var diff_idx_lookup = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++) {
            if (diff_idx_lookup.ContainsKey(nums[i])) {
                return [
                    Math.Min(diff_idx_lookup[nums[i]], i),
                    Math.Max(diff_idx_lookup[nums[i]], i)
                ];
            }

            diff_idx_lookup.Add(target - nums[i], i);
        }

        return null;
    }
}
