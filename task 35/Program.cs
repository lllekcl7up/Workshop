// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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

void PrintArray (int [] array) // тут пишем аргемент получения массива из предедущего метода
{
    Console.Write("[");
    for(int index = 0; index < array.Length; index = index + 1)
    {
        if (index < array.Length - 1) Console.Write($"{array[index]}, ");
        else Console.Write($"{array[index]}");
    }
    Console.WriteLine("]");
}

int CountElements ( int [] array )
{
    int count = 0;
    for ( int index = 0; index < array.Length; index = index + 1)
    {
        if (array[index] > 9 && array[index] < 100) count = count +1;
    }
return count;
}

int [] array = CreateArrayRandomInt(123,0,1000);// 123 элемента от 0 до 1000
PrintArray(array);

int countElements = CountElements(array);
if (countElements > 0) Console.WriteLine($"Колличество двух значных элементов массива {countElements} ");
else Console.WriteLine ("Двухзначных элементов нет");
