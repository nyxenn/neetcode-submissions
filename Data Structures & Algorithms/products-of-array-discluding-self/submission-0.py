class Solution:
    def productExceptSelf(self, nums: List[int]) -> List[int]:
        prod = 1
        zeros = 0

        for n in nums:
            if n != 0:
                prod *= n
            else:
                zeros += 1

        if zeros > 1:
            return [0] * len(nums)

        res = [0] * len(nums)
        for i in range(len(nums)):
            if nums[i] == 0:
                res[i] = prod
            elif zeros == 0:
                res[i] = prod // nums[i]
                
        return res