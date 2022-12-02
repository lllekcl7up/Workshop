// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateMatrixRandomInt (int rows, int columns, int min, int max) // двумерный массив
{
    int [,] matrix = new int [rows, columns];// rows - строки(вертикаль) ,  columns - столбцы(горизонталь)
    Random rndm = new Random();
    
    for(int i = 0; i < matrix.GetLength(0); i = i + 1)
    {
        for (int j = 0; j <matrix.GetLength(1); j++)
        {
            matrix[i,j] = rndm.Next( min, max+1 );// с учетом последнего индекса поэтому + 1
        }
    }
    return matrix;
}


void PrintMatrix(int[,] matrix) // Вывод в консоль Двухмерного массива
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


void SquareEvenNumbersMatrix (int[,] matrix) // Находит четные индексы и заменяет их на квадраты 
{
    for(int i = 0; i < matrix.GetLength(0); i = i + 2)
    {                                    // i = i + 1
        for (int j = 0; j <matrix.GetLength(1); j = j + 2)
        {                                   // j = j + 1
            // if ( i % 2 ==0 && j % 2 ==0)
            matrix[i,j] = matrix[i,j] * matrix[i, j] ;
        }   // можно так же записать matrix[i,j] *= matrix[i,j]
    }
}

int [,] array2D = CreateMatrixRandomInt(3,4, 1, 9); 
PrintMatrix(array2D);
Console.WriteLine();
SquareEvenNumbersMatrix(array2D);
PrintMatrix(array2D);
