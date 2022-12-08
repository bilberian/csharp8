// Задача 62. Спиральный массив.

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
    int k = 0, i = 0, j = 0;

    while (k <= matrix.GetLength(0) * matrix.GetLength(1))
    {
        matrix[i, j] = k;
        if (i == Ibeg && j < matrix.GetLength(1) - Jfin - 1)
            j++;
        else if (j == matrix.GetLength(1) - Jfin - 1 && i < matrix.GetLength(0) - Ifin - 1)
            i++;
        else if (i == matrix.GetLength(0) - Ifin - 1 && j > Jbeg)
            j--;
        else
            i--;

        if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != matrix.GetLength(1) - Jfin - 1))
        {
            Ibeg++;
            Ifin++;
            Jbeg++;
            Jfin++;
        }
        k++;
    }
    for (i = 0; i < matrix.GetLength(0); i++)
    {
        for (j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j]++;
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
            if(matrix[i, j] < 10) Console.Write(" "); //я не поняла как поставить 
            // нули перед цифрой, поэтому выпрямила пробелом
        }
        Console.WriteLine();
    }
}

Console.WriteLine("введите размер массива");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
Console.WriteLine();
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();