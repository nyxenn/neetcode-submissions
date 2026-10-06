public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        var days = new int[temperatures.Length];
        for (int i = temperatures.Length - 2; i >= 0; i--) {
            int j = i + 1;
            while (j < temperatures.Length && temperatures[j] <= temperatures[i]) {
                if (days[j] == 0) {
                    j = temperatures.Length;
                    break;
                }

                j += days[j];
            }

            if (j < temperatures.Length) {
                days[i] = j - i;
            }
        }

        return days;
    }
}
