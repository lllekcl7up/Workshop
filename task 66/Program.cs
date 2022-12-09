// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в 
// промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите натуральное число M: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumFromMtoN(int m, int n)
{
    if (n == m) return n;
    else if (n > m) return m + SumFromMtoN(n, m + 1);
    else return m + SumFromMtoN(n, m - 1);
}
int sum = SumFromMtoN(numberM, numberN);
Console.WriteLine($"Сумма чисел от M до N = {sum}");







