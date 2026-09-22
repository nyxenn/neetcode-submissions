public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var triplets = new List<List<int>>();
        Array.Sort(nums);

        for (int i = 0; i < nums.Length - 2; i++) {
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            var l = i + 1;
            var r = nums.Length - 1;
            var target = -nums[i];

            while (l < r) {
                if (nums[l] + nums[r] < target) l++;
                else if (nums[l] + nums[r] > target) r--;
                else { 
                    triplets.Add([nums[i], nums[l], nums[r]]);
                    l++;
                    r--;
                    while (l < r && nums[l] == nums[l - 1]) l++;
                }
            }
        }

       return triplets; 
    }
}
