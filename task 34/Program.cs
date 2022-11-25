// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int ShowEvenNum (int []array)
{
    int count = 0;
    for (int index = 0; index < array.Length; index = index + 1 )
        if (array[index] % 2 == 0 ) count = count + 1;
        return count;
}


int [] arrayCreate = CreateArrayRandomInt(20, 100, 999);
PrintArray(arrayCreate, "[", "]");
int showEvenNum = ShowEvenNum(arrayCreate);
Console.Write($"\nЧётных чисел {showEvenNum}");

