public class Solution {
    public int Trap(int[] height) {
        int water = 0;
        var containers = new List<(int, int)>();

        // length - 2 since a container needs at least 1 space between left & right wall to be able to contain water
        for (int l = 0; l < height.Length - 2; l++) {
            if (height[l] == 0) continue;

            int r = l + 1;
            int highest = r;
            while (r < height.Length && height[highest] <= height[l]) {
                if (height[r] >= height[highest]) highest = r;
                r++;
            }

            containers.Add((l, highest));
            l = highest - 1; // will be incremented at end of loop, -1 here so that right wall of 1 container can be left wall of another
        }

        foreach (var container in containers) {
            (var l, var r) = container;
            int container_height = Math.Min(height[l], height[r]);
            l += 1; // don't include left border in width and occupied calculations
            int container_width = r - l;
            int occupied = 0;

            while (l < r) {
                occupied += Math.Clamp(height[l], 0, container_height);
                l++;
            }

            water += Math.Max(container_width * container_height - occupied, 0);
        }

        return water;
    }
}
