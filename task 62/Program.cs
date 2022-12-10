// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateSpiralMatrix(int rows, int columns) // двумерный массив
{
    int[,] sqareMatrix = new int[rows, columns];
    int num = 1;
    int j = 0;
    int i = 0;
    while (num <= sqareMatrix.GetLength(0) * sqareMatrix.GetLength(1))
    {
        sqareMatrix[i, j] = num;
        num++;
        if (i <= j + 1 && i + j < sqareMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= sqareMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > sqareMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return sqareMatrix;
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

int [,] spiralArray = CreateSpiralMatrix(10,10); 
PrintMatrix(spiralArray);










