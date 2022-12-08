// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] firstMatrix = FillMatrix(2, 2);
Console.WriteLine("Первая матрица:");
PrintMatrix(firstMatrix);
Console.WriteLine();
int[,] secondMatrix = FillMatrix(2, 2);
Console.WriteLine("Вторая матрица:");
PrintMatrix(secondMatrix);
Console.WriteLine();

int[,] MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] multipliedMatrix = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for(int i = 0; i < firstMatrix.GetLength(0); i++)
        for (int j = 0; j < secondMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < secondMatrix.GetLength(0); k++)
            {
                multipliedMatrix[i,j] += firstMatrix[i,k] * secondMatrix[k,j];
            }
        }
   return multipliedMatrix;    
}
var result = MatrixMultiplication(firstMatrix, secondMatrix);
Console.WriteLine("Произведение матриц:");
PrintMatrix(result);