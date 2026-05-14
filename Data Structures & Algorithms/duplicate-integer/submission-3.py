class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        occ = set()
        for n in nums:
            if n in occ:
                return True
            occ.add(n)

        return False
