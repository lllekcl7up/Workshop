
// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int SumDigits(int num)
{
    int sum = default; // иницилизация переменной по умолчанию НУЛЕМ !
    for (int i = 1; i <= num ; i++)
    {
        sum = sum * i; // тут мы в переменную SUM кладем SUM + i 
    }
    return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

// int SumDigits(int num)
// {
//     int sum = default; // иницилизация переменной по умолчанию НУЛЕМ !
//     for (int i = 0; i <= num ; i++)
//     {
//         sum = sum + i; // тут мы в переменную SUM кладем SUM + i 
//     }
//     return sum;
// }

if (number > 0)
{
int sumDigits = SumDigits(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {sumDigits}");
}
else Console.WriteLine("Требуется ввести натуральное число");