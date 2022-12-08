// Задача 59. Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "  ");
            if (matrix[i, j] < 10) Console.Write(" ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();

int min = matrix[0, 0];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (min > matrix[i, j]) min = matrix[i, j];
    }
}
Console.WriteLine($"Минимальное значение в массиве: {min}");

int impI = 0;
int impJ = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (matrix[i, j] == min)
        {
            impI = i;
            impJ = j;
        }
    }
}
Console.WriteLine($"Минимальное значение массива расположено на {impI + 1} строке столбца {impJ + 1} ");
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i == impI) continue;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if (j == impJ) continue;
        Console.Write(matrix[i, j] + "  ");
        if (matrix[i, j] < 10) Console.Write(" ");
    }
    Console.WriteLine();
}
Console.WriteLine();