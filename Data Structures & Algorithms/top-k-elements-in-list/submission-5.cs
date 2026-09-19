public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqs = new Dictionary<int, int>();
        foreach (var n in nums) {
            if (freqs.ContainsKey(n)) {
                freqs[n]++;
            }
            else {
                freqs[n] = 1;
            }
        }
        
        var buckets = new int[nums.Length].Select(x => new List<int>()).ToArray();
        foreach (var key in freqs.Keys) {
            buckets[freqs[key] - 1].Add(key);
        }

        var output = new int[k];
        int count = 0;
        for (int i = nums.Length - 1; i >= 0; i--) {
            foreach (var n in buckets[i]) {
                output[count] = n;
                count++;
                if (count == k) return output;
            }
        }

        return output;
    }
}
