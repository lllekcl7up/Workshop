// Задача 33: Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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

bool FindNumber (int [] array, int num) // тут пишем аргемент получения массива из предедущего метода
{// тут мы вводим в аргумент искомое число и сам массив

    for(int index = 0; index < array.Length; index = index + 1)
    {
       if (array [index ] == num ) return true;
    }
    return false;
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


int [] arrayFull = CreateArrayRandomInt(10, -9, 999);
PrintArray(arrayFull);
FindNumber(arrayFull,0);

// bool findNumber = FindNumber(arrayFull, 4);
// if (findNumber == true) Console.WriteLine("Да");
// else Console.WriteLine("Нет");


Console.Write("Введите искомое число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Заданное число присутствует в массиве?");
Console.Write(FindNumber(arrayFull, number) ? "да" : "нет");
