class Solution:
    def maxArea(self, heights: List[int]) -> int:
        largest = 0

        l = 0
        r = len(heights) - 1

        while l < r:
            width = r - l
            height = min(heights[l], heights[r])
            area = width * height
            largest = max(area, largest)

            if heights[l] < heights[r]:
                l += 1
            else:
                r -= 1

        return largest
