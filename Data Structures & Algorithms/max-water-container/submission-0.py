class Solution:
    def maxArea(self, heights: List[int]) -> int:
        vols = [0] * len(heights)

        for i, n in enumerate(heights):
            for j, m in enumerate(heights):
                if i == j:
                    continue

                height = min(n, m)
                width = abs(i - j)

                if vols[i] < width * height:
                    vols[i] = width * height

        return max(vols)

