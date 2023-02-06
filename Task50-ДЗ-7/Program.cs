// Задача 50. 
// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1, 7 -> такого элемента в массиве нет



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}


bool IsOutOfRangeIndexes(int i, int j, int[,] array2D)
{
    return ((i < 0 || i > array2D.GetLength(0)) || (j < 0 || j > array2D.GetLength(1)));
}


int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);

Console.WriteLine("Введите индекс строки:");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс колонки:");
int j = Convert.ToInt32(Console.ReadLine());

if (IsOutOfRangeIndexes(i, j, array2D))
{
    Console.WriteLine("Указаны неверные индексы");
    return;
}
Console.WriteLine("Элемент массива - " + array2D[i, j]);
