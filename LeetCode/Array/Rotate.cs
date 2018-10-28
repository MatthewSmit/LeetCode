public partial class Solution
{
    public void Rotate(int[,] matrix)
    {
        var width = matrix.GetLength(0);
        var height = matrix.GetLength(1);
        for (var y = 0; y < height / 2; y++)
        {
            for (var x = y; x < width - y - 1; x++)
            {
                Swap(matrix, x, y, width, height);
            }
        }
    }

    private static void Swap(int[,] matrix, int x, int y, int width, int height)
    {
        var x1 = x;
        var y1 = y;

        var x2 = width - y - 1;
        var y2 = x;

        var x3 = width - x - 1;
        var y3 = height - y - 1;

        var x4 = y;
        var y4 = height - x - 1;

        var tmp = matrix[x1, y1];
        matrix[x1, y1] = matrix[x2, y2];
        matrix[x2, y2] = matrix[x3, y3];
        matrix[x3, y3] = matrix[x4, y4];
        matrix[x4, y4] = tmp;
    }
}