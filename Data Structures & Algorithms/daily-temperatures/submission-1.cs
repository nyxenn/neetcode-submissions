public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var days = new int[temperatures.Length];
        var stack = new Stack<int>();

        for (int i = 0; i < temperatures.Length; i++) {
            while (stack.Count > 0 && temperatures[stack.Peek()] < temperatures[i]) {
                var last = stack.Pop();
                days[last] = i - last;
            }

            stack.Push(i);
        }

        return days;
    }
}
