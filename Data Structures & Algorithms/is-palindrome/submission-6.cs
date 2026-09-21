public class Solution {
    public bool IsPalindrome(string s) {
        if (string.IsNullOrEmpty(s)) return true;
        if (s.Length == 1) return true;

        var start = 0;
        var end = s.Length - 1;

        while (start < s.Length && end >= 0) {
            while (!char.IsLetterOrDigit(s[start]) && start < s.Length - 1) start++;
            while (!char.IsLetterOrDigit(s[end]) && end > 0) end--;
            if (start > end) break;
            if (char.ToLower(s[start]) != char.ToLower(s[end])) return false;
            start++;
            end--;
        }

        return true;
    }
}
