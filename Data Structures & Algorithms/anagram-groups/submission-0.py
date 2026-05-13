class Solution:
    def groupAnagrams(self, strs: List[str]) -> List[List[str]]:
        res = []
        res_counts = []

        for s in strs:
            counts = [0] * 26

            # count letters
            for c in s:
                counts[ord(c) - ord('a')] += 1

            # compare counts to pre-existing counts
            i = self.findSublistIdx(res_counts, counts)
            if i > -1:
                res[i].append(s)
            else:
                res.append([s])
                res_counts.append(counts)
        
        return res

    def findSublistIdx(self, existing, new) -> int:
        if len(existing) == 0:
            return -1

        for i in range(len(existing)):
            equal = True

            for j in range(len(existing[i])):
                if existing[i][j] != new[j]:
                    equal = False
                    break

            if equal:
                return i

        return -1