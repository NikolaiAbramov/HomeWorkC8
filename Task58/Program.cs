// Задача 58 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1, 10]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] matrix1, int[,] matrix2)
{
    int[,] result = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                result[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    Console.WriteLine("Результат умножения матриц:");
    PrintMatrix(result);
}

Console.Clear();
Console.Write("Введите размер первой матрицы: ");
int[] size1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix1 = new int[size1[0], size1[1]];
Console.WriteLine("Введите элементы первой матрицы:");
InputMatrix(matrix1);
Console.WriteLine("Первая матрица:");
PrintMatrix(matrix1);

Console.Write("Введите размер второй матрицы: ");
int[] size2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix2 = new int[size2[0], size2[1]];
Console.WriteLine("Введите элементы второй матрицы:");
InputMatrix(matrix2);
Console.WriteLine("Вторая матрица:");
PrintMatrix(matrix2);

if (size1[1] != size2[0])
{
    Console.WriteLine("Умножение матриц невозможно");
}
else
{
    MultiplyMatrix(matrix1, matrix2);
}
