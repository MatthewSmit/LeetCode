public partial class Solution
{
    public bool IsValidSudoku(char[,] board)
    {
        var valid = new int[9 * 3];

        for (var x = 0; x < 9; x++)
        {
            for (var y = 0; y < 9; y++)
            {
                var letter = board[y, x];
                if (letter == '.')
                {
                    continue;
                }

                var value = letter - '0';

                // Along X
                if ((valid[x] & (1 << value)) != 0)
                {
                    return false;
                }
                valid[x] |= 1 << value;

                // Along Y
                if ((valid[y + 9] & (1 << value)) != 0)
                {
                    return false;
                }
                valid[y + 9] |= 1 << value;

                // In box
                var box = x / 3 + y / 3 * 3;
                if ((valid[box + 18] & (1 << value)) != 0)
                {
                    return false;
                }
                valid[box + 18] |= 1 << value;
            }
        }

        return true;
    }
}