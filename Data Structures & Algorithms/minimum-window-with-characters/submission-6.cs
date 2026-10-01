public class Solution {
    public string MinWindow(string s, string t) {
        if (t.Length > s.Length) return "";

        var targetFreq = new Dictionary<char, int>();
        var windowFreq = new Dictionary<char, int>();
        for (int i = 0; i < t.Length; i++) {
            targetFreq[t[i]] = 1 + targetFreq.GetValueOrDefault(t[i], 0);
            windowFreq[s[i]] = 1 + windowFreq.GetValueOrDefault(s[i], 0);
        }

        var matches = 0;
        foreach ((var k, var v) in targetFreq) {
            if (windowFreq.ContainsKey(k) && windowFreq[k] >= v) {
                matches++;
            }
        }

        int l = 0;
        string shortest = null;

        if (matches == targetFreq.Count) return s.Substring(0, t.Length);

        for (int r = t.Length; r < s.Length; r++) {
            if (!targetFreq.ContainsKey(s[r])) continue;

            windowFreq[s[r]] = 1 + windowFreq.GetValueOrDefault(s[r], 0);
            if (windowFreq[s[r]] == targetFreq[s[r]]) matches++;

            if (matches < targetFreq.Count) continue;
            if (shortest == null || r - l + 1 < shortest.Length) {
                shortest = s.Substring(l, r - l + 1);
            }

            while (l <= r - t.Length) {
                if (!targetFreq.ContainsKey(s[l])) {
                    l++;
                    continue;
                }

                if (windowFreq[s[l]] == targetFreq[s[l]]) break;

                windowFreq[s[l]]--;
                l++;
            }

            if (r - l + 1 < shortest.Length) shortest = s.Substring(l, r - l + 1);
        }

        return shortest;
    }
}
