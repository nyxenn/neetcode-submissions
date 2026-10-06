public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var days = new int[temperatures.Length];
        var deque = new LinkedList<int>();

        for (int i = 0; i < temperatures.Length; i++) {
            while (deque.Count > 0 && temperatures[deque.Last.Value] < temperatures[i]) {
                days[deque.Last.Value] = i - deque.Last.Value;
                deque.RemoveLast();
            }

            deque.AddLast(i);
        }

        return days;
    }
}
