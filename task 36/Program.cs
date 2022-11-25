// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArrayRandomInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rndm = new Random();
    
    for(int index = 0; index < array.Length; index = index + 1)
    {
        array[index] = rndm.Next( min, max+1 );// с учетом последнего индекса поэтому + 1
    }
    return array;
}

void PrintArray(int[] array, string symbA, string symbB)
{
    Console.Write(symbA);
    for (int index = 0; index < array.Length; index = index + 1)
    {
        if (index < array.Length - 1)
             Console.Write($"{array[index]}, ");
        else Console.Write($"{array[index]}");
    }
    Console.Write(symbB);
}

int FinderSumOddElem ( int [] array )
{
    int sumOddElem = default;
    //int num = default;
    for (int index = 0; index < array.Length; index = index + 1)
    {
        if ( index % 2 != 0 ) 
        sumOddElem = sumOddElem + array [index];
    }
    return sumOddElem;
} 
int [] arrayCreate = CreateArrayRandomInt(4, 0, 10);
PrintArray(arrayCreate, "[", "]");
int finderSumOddElem = FinderSumOddElem(arrayCreate);
Console.Write($"\nСумма элементов на нечетных позициях = {finderSumOddElem}");


