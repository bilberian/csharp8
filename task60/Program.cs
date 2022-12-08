// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, 
// добавляя индексы каждого элемента.


var numbers = Enumerable.Range(10, 100).ToList(); //я не поняла, где указывать начальное значение - здесь или ниже в Rndomnext

int[,,] FillCube(int rows, int columns, int pages)
{
    int[,,] cube = new int[rows, columns, pages];
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                var randomIndex = new Random().Next(numbers.Count);
                var number = numbers[randomIndex];
                numbers.RemoveAt(randomIndex);

                cube[i, j, k] = number;
            }
        }
    }
    return cube;
}

void PrintCube(int[,,] cube)
{
    for (int i = 0; i < cube.GetLength(0); i++)
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k}) ");
            }
        }
        Console.WriteLine(); // не выводится как в примере - всегда в размере строк массива - так должно быть?
    }
    // Console.WriteLine();
}

Console.WriteLine("введите количество строк массива");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов массива");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество страниц массива");
int p = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,,] cube = FillCube(m, n, p); /// если указать 5/5/5 - то будет краш (out of range)

PrintCube(cube);
Console.WriteLine();