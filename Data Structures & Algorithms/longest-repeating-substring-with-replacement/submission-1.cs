public class Solution {
    public int CharacterReplacement(string s, int k) {
        Dictionary<char, int> counts = new();

       int longest = 0;
       int maxf = 0;
       int l = 0;
       int r = 0;

       while (r < s.Length) {
            counts[s[r]] = 1 + counts.GetValueOrDefault(s[r], 0);
            maxf = Math.Max(maxf, counts[s[r]]);

            while ((r - l + 1) - maxf > k) {
                counts[s[l]] -= 1;
                l++;
            }

            longest = Math.Max(longest, r - l + 1);
            r++;
       }

       return longest;
    }
}
