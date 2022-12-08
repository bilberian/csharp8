// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
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
            Console.Write(matrix[i, j] + " ");
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

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = j + 1; k < matrix.GetLength(1); k++)
        {
            if (matrix[i, j] < matrix[i, k])
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, k];
                matrix[i, k] = temp;
            }
        }
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}

