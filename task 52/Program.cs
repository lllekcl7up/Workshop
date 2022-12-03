// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrixRandomInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
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
            if (j < matrix.GetLength(1) -1) 
            Console.Write($"{matrix[i,j], 4}| ");
            else Console.Write($"{matrix[i,j], 4}");
        }
    Console.WriteLine("|");
    }
}

double[] AverageSum (int [,] matrix)
{
    double [] average = new double[matrix.GetLength(1)];
    for (int j = 0; j <matrix.GetLength(1); j++)
    {
        for (int i = 0; i <matrix.GetLength(0); i++)
        {
            average[j] = average[j] + matrix[i,j];
        }
        average[j] = Math.Round (average[j] / matrix.GetLength(0),2);
    }
    return average;
}

void PrintArray(double[] array)
{
    Console.Write("|");
    for (int index = 0; index < array.Length; index = index + 1)
    {
        if (index < array.Length - 1)
             Console.Write($"{array[index],4}| ");
        else Console.Write($"{array[index],4}");
    }
    Console.Write("|");
}

int [,] array2D = CreateMatrixRandomInt(3,4,1,10); 
PrintMatrix(array2D);
double [] averageSum = AverageSum(array2D);
Console.Write("Среднее арифметическое элементов в каждом столбце: ");
PrintArray(averageSum);









