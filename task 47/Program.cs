﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.

// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double [,] CreateMatrixRandomDouble(int rows, int columns, int min, int max)
{
    double [,] matrix = new double [rows, columns];
    Random rndm = new Random();

    for (int i = 0; i <matrix.GetLength(0); i++)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j] = Math.Round(rndm.NextDouble() * (max - min) + min,2);
        }
    }
    return matrix;
}

void PrintMatrix(double [,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) -1)
            Console.Write($"{matrix[i,j], 7 }|");
                else Console.Write($"{matrix[i,j],7 }");
        }
    Console.WriteLine("|");
    }
}

double [,] array2D = CreateMatrixRandomDouble(3,4, 1 , 10);
PrintMatrix(array2D);