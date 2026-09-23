public class Solution {
    public int Trap(int[] height) {
        int water = 0;

        int l = 0;
        int r = height.Length - 1;
        int max_l = height[l];
        int max_r = height[r];

        while (l < r) {
            if (max_l < max_r) {
                l++;
                max_l = Math.Max(max_l, height[l]);
                water += Math.Max(max_l - height[l], 0);
            }
            else {
                r--;
                max_r = Math.Max(max_r, height[r]);
                water += Math.Max(max_r - height[r], 0);
            }
        }

        return water;
    }
}
