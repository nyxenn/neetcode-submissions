public class Solution {
    public bool IsValidSudoku(char[][] board) {
       var rows = new int[9];
       var cols = new int[9];
       var squares = new int[9];

       for (int row = 0; row < board.Length; row++) {
        for (int col = 0; col < board[row].Length; col++) {
            if (board[row][col] == '.') continue;

            var idx = board[row][col] - '1';
            var square = (row / 3 * 3) + (col / 3 + 1) - 1;
            if ((rows[row] & (1 << idx)) > 0 ) return false;
            if ((cols[col] & (1 << idx)) > 0 ) return false;
            if ((squares[square] & (1 << idx)) > 0 ) return false;

            rows[row] |= 1 << idx;
            cols[col] |= 1 << idx;
            squares[square] |= 1 << idx;
        }
       }

       return true;
    }
}
