// Задача 49: 
// Задайте двумерный массив. 
// Найдите элементы, у которых оба индекса чётные, 
// и замените эти элементы на их квадраты.

// Например, изначально массив выглядел вот так:
// 1 4 7 2    
// 5 9 2 3
// 8 4 2 4

// Новый массив будет выглядеть вот так:
// 1 4 49 2
// 5 9 2 3
// 64 4 4 4


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


void FindEvenValues(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i+=2)
    {
        for (int j = 0; j < matrix.GetLength(1); j+=2)
        {
            matrix[i, j] *= matrix[i, j];
        }
    }
}

int[,] matr = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(matr);
FindEvenValues(matr);
Console.WriteLine();
PrintMatrix(matr);