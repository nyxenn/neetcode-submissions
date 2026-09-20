public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        var output = new int[nums.Length];
        output[0] = 1;

        for (int i = 1; i < nums.Length; i++) {
            output[i] = output[i-1] * nums[i-1];
        }

        var runningProduct = 1;
        for (int i = nums.Length - 1; i >= 0; i--) {
            output[i] *= runningProduct;
            runningProduct *= nums[i];
        }

        return output;
    }
}
