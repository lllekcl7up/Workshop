// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д.

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


int SumDiogonalMatrix (int[,] matrix) // двумерный массив
{
    int sum = default;
    int minIndex = matrix.GetLength(0);
    if (matrix.GetLength(1) < matrix.GetLength(0)) minIndex = matrix.GetLength(1);
    for(int i = 0; i < minIndex; i = i + 1)
      sum = matrix[i,i] + sum;
// можно записать как sum += matrix[i,j] 
    return sum;
}




int [,] array2D = CreateMatrixRandomInt(3,7, 1, 9); 
PrintMatrix(array2D);
Console.WriteLine();
int sumDiogonalMatrix = SumDiogonalMatrix(array2D);
Console.Write($"Сумма элементов, находящихся по диагонали = {sumDiogonalMatrix}");
