public class Solution {
    public bool IsValidSudoku(char[][] board) {
       var rows = new int[9].Select(x => new int[9]).ToArray();
       var cols = new int[9].Select(x => new int[9]).ToArray();
       var squares = new int[9].Select(x => new int[9]).ToArray();

       for (int row = 0; row < board.Length; row++) {
        for (int col = 0; col < board[row].Length; col++) {
            if (board[row][col] == '.') continue;

            var idx = board[row][col] - '1';
            var square = (row / 3 * 3) + (col / 3 + 1) - 1;
            if (rows[row][idx] == 1) return false;
            if (cols[col][idx] == 1) return false;
            if (squares[square][idx] == 1) return false;

            rows[row][idx] = 1;
            cols[col][idx] = 1;
            squares[square][idx] = 1;
        }
       }

       return true;
    }
}
