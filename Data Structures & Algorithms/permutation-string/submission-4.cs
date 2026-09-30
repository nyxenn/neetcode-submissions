public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        var counts = new int[26];
        for (int i = 0; i < s1.Length; i++) {
            counts[s1[i] - 'a']++;
            counts[s2[i] - 'a']--;
        }

        var matches = 0;
        for (int i = 0; i < 26; i++) {
            if (counts[i] == 0) matches++;
        }

        int l = 0;
        for (int r = s1.Length; r < s2.Length; r++) {
            if (matches == 26) return true;

            int idx = s2[r] - 'a';
            counts[idx]--;
            if (counts[idx] == 0) matches++;
            else if (counts[idx] == -1) matches--;

            idx = s2[l] - 'a';
            counts[idx]++;
            if (counts[idx] == 0) matches++;
            else if (counts[idx] == 1) matches--;
            l++;
        }

        return matches == 26;
    }
}
