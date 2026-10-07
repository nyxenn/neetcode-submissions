public class Solution {
    public int LargestRectangleArea(int[] heights) {
        var stack = new Stack<(int left, int height)>();
        var max = 0;

        for (int i = 0; i < heights.Length; i++) {
            var leftIdx = i;
            while (stack.Count > 0 && stack.Peek().height > heights[i]) {
                (leftIdx, var height) = stack.Pop();
                max = Math.Max(max, (i - leftIdx) * height);
            }

            stack.Push((leftIdx, heights[i]));
        }

        while (stack.Count > 0) {
            (var left, var height) = stack.Pop();
            max = Math.Max(max, (heights.Length - left) * height);
        }

        return max;
    }
}
