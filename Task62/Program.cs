Console.Clear();
int[,] matrix = new int[4, 4];
int count = 1;
int minRow = 0, maxRow = 3, minCol = 0, maxCol = 3;

while (count <= 16)
{
    for (int i = minCol; i <= maxCol; i++)
    {
        matrix[minRow, i] = count++;
    }

    for (int i = minRow + 1; i <= maxRow; i++)
    {
        matrix[i, maxCol] = count++;
    }

    for (int i = maxCol - 1; i >= minCol; i--)
    {
        matrix[maxRow, i] = count++;
    }

    for (int i = maxRow - 1; i > minRow; i--)
    {
        matrix[i, minCol] = count++;
    }

    minRow++;
    minCol++;
    maxRow--;
    maxCol--;
}

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"{matrix[i, j]:00} \t");
    }
    Console.WriteLine();
}