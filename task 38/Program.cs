// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRandomDouble (int size, int min, int max)
{
    double [] array = new double [size];
    Random rndm = new Random();
    
    for(int index = 0; index < array.Length; index = index + 1)
    {
        array[index] = Math.Round(rndm.NextDouble() * (max - min) + min,2);
    }
    return array;
}

void PrintArray(double[] array, string symbA, string symbB)
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

double MaxElement ( double [] array)
{
    double max = array[0];
    for (int index = 0; index <array.Length; index = index +1)
    {
        if (array[index] > max ) max = array[index];
    }
    return max;
}

double MinElement (double [] array)
{
    double min = array[0];
    for (int index = 0; index <array.Length; index = index + 1)
    {
        if (array[index] < min ) min = array[index];
    }
    return min;
}


double [] arrayCreate = CreateArrayRandomDouble(4, 0, 10);
PrintArray(arrayCreate, "[", "]");
double maxElement = MaxElement(arrayCreate);
double minElement = MinElement(arrayCreate);

Console.Write($"\n Максимальный элемент = {maxElement} \n Минимальный элемент  = {minElement}");
Console.WriteLine($"\n Разница между ними  = {Math.Round(maxElement - minElement,2)}");