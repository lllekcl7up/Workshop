// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.


Console.WriteLine("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

NumbersMToN(numberM,numberN);

void NumbersMToN(int numbM, int numbN)
{
    if (numbM > numbN)
    {
        Console.Write($"{numbM} ");
        NumbersMToN(numbM - 1, numbN);
    }
    else if (numbM < numbN)
    {
        Console.Write($"{numbM} ");
        NumbersMToN(numbM + 1, numbN);
    }
    else
    {
        Console.Write($"{numbM} ");
    }
}