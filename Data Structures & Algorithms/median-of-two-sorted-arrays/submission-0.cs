public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n = nums1.Length + nums2.Length;
        if (n == 0) return 0;

        var sorted = nums1.Concat(nums2).ToArray();
        Array.Sort(sorted);
        return n % 2 == 1 ? sorted[n / 2] : (sorted[n / 2 - 1] + sorted[n / 2]) / 2.0;
    }
}
