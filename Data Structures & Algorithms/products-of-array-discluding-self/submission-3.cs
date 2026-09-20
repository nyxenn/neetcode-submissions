public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int zeroes = 0;
        long totalProduct = 1;

        foreach (var n in nums) {
            if (n == 0)  zeroes++;
            else totalProduct *= n;
        }

        if (zeroes > 1) return new int[nums.Length];

        return nums.Select(x => {
            if (x == 0) return (int)totalProduct;
            else if (zeroes > 0) return 0;
            else return (int)(totalProduct / x);
        }).ToArray();
    }
}
