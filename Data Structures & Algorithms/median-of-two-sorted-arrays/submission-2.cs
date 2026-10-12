public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int n = nums1.Length + nums2.Length;
        if (n == 0) return 0;
        if (nums1.Length == 0) return n % 2 == 1 ? nums2[n / 2] : (nums2[n / 2 - 1] + nums2[n / 2]) / 2.0;
        if (nums2.Length == 0) return n % 2 == 1 ? nums1[n / 2] : (nums1[n / 2 - 1] + nums1[n / 2]) / 2.0;

        int l1 = 0;
        int l2 = 0;
        int med1 = 0;
        int med2 = 0;

        while (l1 + l2 <= n / 2) {
            med2 = med1;
            if (l1 >= nums1.Length)  {
                med1 = nums2[l2];
                l2++;
            }
            else if (l2 >= nums2.Length) {
                med1 = nums1[l1];
                l1++;
            }
            else if (nums1[l1] <= nums2[l2]) {
                med1 = nums1[l1];
                l1++;
            }
            else {
                med1 = nums2[l2];
                l2++;
            }
        }

        return n % 2 == 1 ? med1 : (med1 + med2) / 2.0;
    }
}
