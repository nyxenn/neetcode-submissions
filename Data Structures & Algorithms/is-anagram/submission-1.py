class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        if len(s) != len(t):
            return False

        occ_map_s = {}
        occ_map_t = {}
        for i in range(len(s)):
            occ_map_s[s[i]] = occ_map_s.get(s[i], 0) + 1
            occ_map_t[t[i]] = occ_map_t.get(t[i], 0) + 1

        for k in occ_map_s.keys():
            if occ_map_s.get(k) != occ_map_t.get(k):
                return False

        return True
