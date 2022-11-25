// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int [] CreateArrayRandomInt (int size, int min, int max)
{
    int [] array = new int [size];
    Random rndm = new Random();
    
    for(int index = 0; index < array.Length; index = index + 1)
    {
        array[index] = rndm.Next( min, max+1 );// с учетом последнего индекса поэтому + 1
    }
    return array;
}

void InverseArray (int [] array) // тут пишем аргемент получения массива из предедущего метода
{// тут перезаписываются знаки элемента массива
    for(int index = 0; index < array.Length; index = index + 1)
    {
        array[index] = array[index] * -1;
    }
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
int [] arrayFull = CreateArrayRandomInt(4, -9, 9);
PrintArray(arrayFull);
InverseArray(arrayFull);
PrintArray(arrayFull);