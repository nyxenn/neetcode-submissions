public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return true;
        if (s.Length == 1) return true;

        var start = 0;
        var end = s.Length - 1;

        while (start < end) {
            while (start < end && !char.IsLetterOrDigit(s[start])) start++;
            while (end > start && !char.IsLetterOrDigit(s[end])) end--;
            if (char.ToLower(s[start]) != char.ToLower(s[end])) return false;
            start++;
            end--;
        }

        return true;
    }
}
