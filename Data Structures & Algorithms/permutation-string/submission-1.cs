public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if (s1.Length > s2.Length) return false;

        var counts = new int[26];

        foreach (var c in s1) {
            counts[c - 'a']++;
        }

        int l = 0;
        for (int r = 0; r < s2.Length; r++) {
            counts[s2[r] - 'a']--;

            while (counts[s2[r] - 'a'] < 0) {
                counts[s2[l] - 'a']++;
                l++;
            }

            if (r - l + 1 == s1.Length) return true;
        }

        return false;
    }
}
