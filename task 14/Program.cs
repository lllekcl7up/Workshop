﻿// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да



Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

bool Result(int numberA)
{
    return numberA % 7 == 0 && numberA % 23 == 0;
}

Console.WriteLine( Result(numberA) ? "Кратно 7 и 23" : "Не кратно 7 и 23");



//простое решение с if
// if (numberA % 7 == 0 && numberA % 23 == 0)
// {
//     Console.WriteLine("Кратно 7 и 23: ");
// }
// else Console.WriteLine("Не кратно 7 и 23: ");
