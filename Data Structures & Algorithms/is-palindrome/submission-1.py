class Solution:
    def isPalindrome(self, s: str) -> bool:
        norm = ""
        for c in s.lower():
            if (c >= 'a' and c <= 'z') or (c >= '0' and c <= '9'):
                norm += c

        length = len(norm) - 1
        for i in range(len(norm)):
            if norm[i] != norm[length - i]:
                return False

        return True

        