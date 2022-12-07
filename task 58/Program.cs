// Задача 58: Задайте две матрицы. Напишите программу, которая будет 
// находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MultiplicationMatrix(int[,] firstArray2d, int[,] secondArray2d)
{
    int[,] multiArray = new int[firstArray2d.GetLength(0), firstArray2d.GetLength(1)];
    for (int i = 0; i < firstArray2d.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray2d.GetLength(1); j++)
        {
            for (int k = 0; k < firstArray2d.GetLength(1); k++)
            {
                multiArray[i, j] += firstArray2d[i, k] * secondArray2d[k, j];
            }
        }
    }
    return multiArray;
}

int [,] firstArray2D = CreateMatrixRandomInt(2,2,1,10); 
int [,] secondArray2D = CreateMatrixRandomInt(2,2,1,10);
Console.WriteLine("Первая матрица \n     ↓");
PrintMatrix(firstArray2D);
Console.WriteLine("Вторая матрица: \n     ↓");
PrintMatrix(secondArray2D);
Console.WriteLine("Произведение двух матриц: \n     ↓");
int [,] multiplicationMatrix = MultiplicationMatrix(firstArray2D,secondArray2D);
PrintMatrix(multiplicationMatrix);


