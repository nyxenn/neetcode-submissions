public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        var s1Counts = new int[26];
        var s2Counts = new int[26];
        for (int i = 0; i < s1.Length; i++) {
            s1Counts[s1[i] - 'a']++;
            s2Counts[s2[i] - 'a']++;
        }

        var matches = 0;
        for (int i = 0; i < 26; i++) {
            if (s1Counts[i] == s2Counts[i]) matches++;
        }

        int l = 0;
        for (int r = s1.Length; r < s2.Length; r++) {
            if (matches == 26) return true;

            int idx = s2[r] - 'a';
            s2Counts[idx]++;
            if (s1Counts[idx] == s2Counts[idx]) matches++;
            else if (s1Counts[idx] == s2Counts[idx] - 1) matches--;

            idx = s2[l] - 'a';
            s2Counts[idx]--;
            if (s1Counts[idx] == s2Counts[idx]) matches++;
            else if (s1Counts[idx] == s2Counts[idx] + 1) matches--;
            l++;
        }

        return matches == 26;
    }
}
