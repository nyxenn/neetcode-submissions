class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prefixProds = [1] * len(nums)
        suffixProds = [1] * len(nums)

        for i in range(len(nums)):
            if i > 0:
                prefixProds[i] = prefixProds[i - 1] * nums[i - 1]
            
            if i < len(nums) - 1:
                suffixIdx = len(nums) - 2 - i
                suffixProds[suffixIdx] = suffixProds[suffixIdx + 1] * nums[suffixIdx + 1]

        res = [0] * len(nums)
        for i in range(len(nums)):
            res[i] = prefixProds[i] * suffixProds[i]

        return res