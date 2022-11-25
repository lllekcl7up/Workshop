// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int [] NewArray( int[] array)
{
    int newArraySize = array.Length / 2;
    if (array.Length % 2 == 1) newArraySize = newArraySize + 1;
    int[] newArray = new int [newArraySize];// тут в новом массиве мы получили новый размер 
    for (int index = 0; index <array.Length / 2 ; index = index + 1)
    {
        newArray[index] = array[index] * array[array.Length - 1 - index];
    }
    if (array.Length % 2 == 1) newArray[newArraySize - 1] = array[array.Length / 2];
    return newArray;
}

int [] array = CreateArrayRandomInt ( 5, 0, 10);
PrintArray(array);
int[] newArr = NewArray(array);
PrintArray(newArr);
