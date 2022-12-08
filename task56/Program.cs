// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

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

int[,] matrix = FillMatrix(5, 8);
PrintMatrix(matrix);
Console.WriteLine();

Console.Write("Сумма элементов каждой строки: ");
int[] countArray = new int[matrix.GetLength(0)];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i, j];
    }
    countArray[i] = sum;
}
Console.Write(string.Join(", ", countArray));
Console.WriteLine();

int min = countArray[0];
int line = 0;
for (line = 0; line < countArray.Length; line++)
{
    if (min > countArray[line]) min = countArray[line];
}
Console.WriteLine($"Наименьшая сумма элементов: {min}");

for (line = 0; line < countArray.Length; line++)
{
    if (countArray[line] == min)
        Console.WriteLine($"Строка с наименьшей суммой элементов: {line + 1} строка");
}
Console.WriteLine();
