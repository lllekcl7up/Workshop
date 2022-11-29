// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


int[] EnterDigits()
{
    Console.Write("Введите колличество чисел: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите число {i + 1}: ");
        int digit = Convert.ToInt32(Console.ReadLine());
        array[i] = digit;
    }
    return array;
}

// void PrintArray(int[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
//         else Console.Write($"{arr[i]}");
//     }
//     Console.WriteLine("]");
// }

int QuantityPositiveDigits( int [] array)
{
    int count = 0;
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i] > 0) count = count + 1;        
    }
    return count;
}

int [] arrayCreate = EnterDigits();
// PrintArray(arrayCreate);

int quantityPositiveDigits = QuantityPositiveDigits(arrayCreate);
Console.Write($"\nВы ввели {quantityPositiveDigits} положительных чисел");




