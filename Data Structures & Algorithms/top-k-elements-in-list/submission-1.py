class Solution:
    def topKFrequent(self, nums: List[int], k: int) -> List[int]:
        freqMap = {}

        for i in range(len(nums)):
            num = nums[i]
            if num in freqMap:
                freqMap[num] += 1
            else:
                freqMap[num] = 1

        bucket = [None] * len(nums)
        for n, f in freqMap.items():
            if bucket[f - 1] is None:
                bucket[f - 1] = []
            bucket[f - 1].append(n)

        res = []
        for i in range(len(bucket)):
            if len(res) == k:
                break
            idx = len(bucket) - 1 - i
            if bucket[idx] is not None:
                res += bucket[idx]

        return res
