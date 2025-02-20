public class Solution {
    public bool IsValidSudoku(char[][] board) {
        List<HashSet<char>> rows = new();
        List<HashSet<char>> cols = new();
        List<HashSet<char>> quads = new();
        for (var i = 0; i < 9; i++)
        {
            rows.Add(new HashSet<char>());
            cols.Add(new HashSet<char>());
            quads.Add(new HashSet<char>());
        }
        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                var box = board[r][c];
                if (box != '.')
                {
                    if (!rows[r].Add(box))
                    {
                        return false;
                    }
                    if (!cols[c].Add(box))
                    {
                        return false;
                    }
                    var quadIndex = (r / 3) * 3 + c / 3;
                    if (!quads[quadIndex].Add(box))
                    {
                        return false;
                    }
                }
            }
        }
        //get first populated element
        //check rest of array for that value
        //if any duplicates, not valid
        //check rest of arrays at same index position
        //if any duplicates, not valid
        //check the rest of the quadrant for that value -- how to do this gracefully
        //if any duplicates, not valid
        return true;
    }
}
