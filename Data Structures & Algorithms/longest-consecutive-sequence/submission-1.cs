public class Solution {
    public int LongestConsecutive(int[] nums) {
        var set = new HashSet<int>(nums);

        int longest = 0;
        foreach (var n in nums) {
            if (set.Contains(n - 1)) continue;

            int chain = 1;
            int next = n + 1;
            while (set.Contains(next)) {
                chain++;
                next++;
            }

            if (chain > longest) longest = chain;
        }

        return longest;
    }
}
