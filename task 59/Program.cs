// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.


int[,] CreateMatrixRandomInt (int rows, int columns, int min, int max) // двумерный массив
{
    int [,] matrix = new int [columns, rows];// rows - строки ,  columns - столбцы
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

(int Column, int Row) SearchMinValue(int[,]matrix)
{    
    int row = 0;
    int col = 0;
    int min = matrix[0,0];
    for (int i = 0; i <matrix.GetLength(0);i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
    {
        if(min > matrix[i,j])
        {
            min = matrix[i,j];
            row = i;
            col = j;
        }
    }
    }
    return (row,col);
}


int[,] DeleteMinValueRowCol(int[,] matrix, (int row, int col) minValue) 
{ 
    int[,] crop = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1]; 
    for (int i = 0,  k = 0; i < crop.GetLength(0); i++, k++) 
    { 
        if (i == minValue.row) k++; 
        for (int j = 0, m = 0; j < crop.GetLength(1); j++, m++) 
        { 
            if (j == minValue.col) m++; 
            crop[i, j] = matrix[k, m]; 
        } 
    } 
    return crop; 
}


int [,] array2D = CreateMatrixRandomInt(5,5,1,9);
PrintMatrix(array2D);
Console.WriteLine();
(int Row, int Column) minValue = SearchMinValue(array2D);
int [,] croppedArray = DeleteMinValueRowCol(array2D,minValue);
PrintMatrix(croppedArray);




