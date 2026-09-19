public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var output = new Dictionary<string, List<string>>();

        foreach (var str in strs) {
            var freqs = new int[26];
            foreach (var c in str) {
                freqs[c - 'a'] += 1;
            }

            var key = string.Join(",", freqs);
            if (output.ContainsKey(key)) {
                output[key].Add(str);
                continue;
            }

            output[key] = new List<string> { str };
        }

        return output.Select(x => x.Value).ToList();
    }
}
