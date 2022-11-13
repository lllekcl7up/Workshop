// Напишите программу, которая на вход принимает число и выдает, является ли число чётным(делится ли оно на 2 без остатка)

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
    if (numberA % 2 == 0 )Console.WriteLine($" {numberA} - является чётным числом");
else Console.WriteLine($" {numberA} - не является четным числом");