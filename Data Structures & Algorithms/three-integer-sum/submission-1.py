class Solution:
    def threeSum(self, nums: List[int]) -> List[List[int]]:
        nums.sort()
        out = []
        size = len(nums)

        for i in range(size - 2):
            if i > 0 and nums[i] == nums[i - 1]:
                continue

            l = i + 1
            r = size - 1

            while True:
                if l >= r:
                    break

                a, b, c = nums[i], nums[l], nums[r]
                sum = a + b + c

                if sum > 0:
                    r -= 1
                elif sum < 0:
                    l += 1
                else:
                    out.append([a, b, c])
                    l += 1
                    while l < size and nums[l] == nums[l - 1]:
                        l += 1

        return out

