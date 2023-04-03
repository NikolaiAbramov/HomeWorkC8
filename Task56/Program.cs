// Задача 56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11); // [1; 10]
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

void MinStrokaMatrix(int[,] matrix)
{
int minStrokaIndex = 0;
int minStrokaSum = int.MaxValue;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int StrokaSum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            StrokaSum += matrix[i, j];
        }
        
            if (StrokaSum < minStrokaSum)
            {
                minStrokaSum = StrokaSum;
                minStrokaIndex = i;
            }
    }
        Console.WriteLine($"Строка с наименьшей суммой: {minStrokaIndex + 1}");  
}

Console.Clear();
Console.Write("Введите размерность массива: ");
int[] size = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив");
PrintMatrix(matrix);
MinStrokaMatrix(matrix);