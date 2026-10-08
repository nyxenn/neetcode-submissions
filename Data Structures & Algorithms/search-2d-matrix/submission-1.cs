public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var l = 0;
        var r = matrix.Length;
        var row = (r - l) / 2;

        // Lower bound binary search
        while (l < r) {
            if (matrix[row][0] <= target) l = row + 1;
            else r = row;
            row = l + (r - l) / 2;
        }

        // Target should be in (row - 1)
        row -= 1;
        if (row < 0) return false;

        l = 0;
        r = matrix[row].Length - 1;
        var m = (r - l) / 2;

        while (l <= r) {
            if (matrix[row][m] == target) return true;
            else if (matrix[row][m] < target) l = m + 1;
            else r = m - 1;

            m = l + (r - l) / 2;
        }

        return false;
    }
}
