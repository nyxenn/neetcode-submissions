class Solution:
    def twoSum(self, nums: List[int], target: int) -> List[int]:
        diff_idx = {}
        match = []

        for i in range(len(nums)):
            if diff_idx.get(nums[i]) is not None:
                match.append(diff_idx[nums[i]])
                match.append(i)
                break

            diff_idx[target - nums[i]] = i

        return match
