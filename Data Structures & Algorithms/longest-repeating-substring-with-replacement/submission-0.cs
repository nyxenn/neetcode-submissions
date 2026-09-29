public class Solution {
    public int CharacterReplacement(string s, int k) {
       int[] counts = new int[26];
       HashSet<char> current = new();

       int longest = 0;
       int l = 0;
       int r = 0;

       while (r < s.Length) {
            int idx = s[r] - 'A';
            counts[idx]++;
            current.Add(s[r]);

            while ((counts.Max() + k) < (r - l + 1)) {
                counts[s[l] - 'A'] -= 1;
                if (counts[s[l] - 'A'] == 0) current.Remove(s[l]);
                l++;
            }

            longest = Math.Max(longest, Math.Clamp(counts.Max() + k, 0, r - l + 1));
            r++;
       }

       return longest;
    }
}
