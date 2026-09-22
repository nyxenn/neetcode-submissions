public class Solution {
    public int MaxArea(int[] heights) {
        int max = 0;
        int l = 0;
        int r = heights.Length - 1;

        while (l < r) {
            int height = Math.Min(heights[l], heights[r]);
            int width = r - l;
            if (height * width > max) max = height * width;

            if (heights[l] <= heights[r]) l++;
            else r--;
        }

        return max;
    }
}
