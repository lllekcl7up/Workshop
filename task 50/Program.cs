// Задача 50. Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает значение этого элемента 
// или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.Write("Введите индекс строки: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите индекс столбца: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrixRandomInt(int row, int col, int min, int max)
{
    int[,] matrix = new int[row, col];
    Random rndm = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rndm.Next(min, max + 1);
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
            if (j < matrix.GetLength(1) - 1)
                Console.Write($"{matrix[i, j],4}|");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

bool CheckValue(int[,] matrix)
{
    if (rows >= matrix.GetLength(0) || columns >= matrix.GetLength(1)) return false;
    if (rows < 0 || columns < 0) return false;
    return true;
}

int[,] array2D = CreateMatrixRandomInt(3, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine(CheckValue(array2D) 
? $"Число в таблице по адресу [{rows},{columns}] = {array2D[rows, columns]}": "Такого числа в таблице нет");

