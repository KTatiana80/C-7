// Задача 51: 
// Задайте двумерный массив. 
// Найдите сумму элементов, находящихся на главной диагонали 
// (с индексами (0,0); (1;1) и т.д.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// Сумма элементов главной диагонали: 1+9+2 = 12

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3} | ");
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int DiagonalValueSum(int[,] matrix)
{
    int sum = default;
    int size = matrix.GetLength(0);
    if (matrix.GetLength(0) > matrix.GetLength(1)) size = matrix.GetLength(1);

    for (int i = 0; i < size; i++)
    {
        sum += matrix[i, i];
    }
    return sum;
}

int[,] matr = CreateMatrixRndInt(4, 3, 0, 10);
PrintMatrix(matr);
int diagonalValueSum = DiagonalValueSum(matr);
Console.WriteLine();
Console.WriteLine($"Сумма диагональных значений равна {diagonalValueSum}");