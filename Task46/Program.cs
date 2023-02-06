// Задача 46: 
// Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4.



//      0   1   2   3

//0     1   4   8  19
//1     5  -2  33  -2
//2    77   3   8   1


// Создание двумерного массива
//                            строки     столбцы
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns]; // 0, 1 строки, столбцы
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)  // цикл проходит по строкам(количество элементов)
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // цикл проходит по столбцам(количество элементов)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// Вывод двумерного массива
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3} | ");
            else Console.Write($"{matrix[i,j], 3} ");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);