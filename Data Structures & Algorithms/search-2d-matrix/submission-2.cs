public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        var l = 0;
        var r = matrix.Length * matrix[0].Length - 1;
        var m = (r - l) / 2;

        while (l <= r) {
            var i = m / matrix[0].Length;
            var j = m % matrix[0].Length;

            if (matrix[i][j] == target) return true;
            else if (matrix[i][j] < target) l = m + 1;
            else r = m - 1;

            m = l + (r - l) / 2;
        }

        return false;
    }
}
