public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        var occ_dict = new Dictionary<char, int>();
        foreach (char c in s) {
            occ_dict[c] = occ_dict.ContainsKey(c) ? occ_dict[c] + 1 : 1;
        }

        foreach (char c in t) {
            if (!occ_dict.ContainsKey(c)) return false;
            if (occ_dict[c] == 0) return false;
            occ_dict[c] -= 1;
        }

        return occ_dict.Values.All(x => x == 0);
    }
}
