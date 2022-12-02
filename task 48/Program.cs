﻿// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrixInt (int rows, int columns) // двумерный массив
{
    int [,] matrix = new int [rows, columns];// rows - строки(вертикаль) ,  columns - столбцы(горизонталь)

    for(int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j ;
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
         Console.Write("[");
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i,j], 4}, ");
               else Console.Write($"{matrix[i,j], 4}");
        }
    Console.WriteLine("]");
    }
}

int [,] array2D = CreateMatrixInt(3,4); 
PrintMatrix(array2D);



