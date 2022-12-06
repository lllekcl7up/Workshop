﻿// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.


int[,] CreateMatrixRandomInt (int rows, int columns, int min, int max)
{
    int [,] matrix = new int [rows, columns];
    Random rndm = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j] = rndm.Next( min, max+1 );
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
            if (j < matrix.GetLength(1) -1) 
            Console.Write($"{matrix[i,j], 4}| ");
            else Console.Write($"{matrix[i,j], 4}");
        }
    Console.WriteLine("|");
    }
}

int [,] SwapRowsColumns(int[,] matrix)
{
    int [,] temp = new int [ matrix.GetLength(1), matrix.GetLength(0)];
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            temp [j,i] = matrix[i,j];
        }
    }
    return temp;
}

void Output(int[,] matrix)
{
    if (matrix.GetLength(1) == matrix.GetLength(0))
    {
        int[,] swapedArray = SwapRowsColumns(matrix);
        PrintMatrix(swapedArray);
    }
    else
    {
        Console.WriteLine("\nМассив не квадратный, процедура не выполнима.");
    }
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int [,] array2D = CreateMatrixRandomInt(rows,columns,1,9);
PrintMatrix(array2D);
Console.WriteLine();
Output(array2D);
