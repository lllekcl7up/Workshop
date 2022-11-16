//Напишите программу, которая принимает на вход цифру, обозначающую
//день недели,и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число для проверки дня недели (от 1 до 7): ");
int numberA = Convert.ToInt32(Console.ReadLine());

if (numberA > 0 && numberA < 8)
    {
        if (numberA == 7 || numberA == 6)
        {
            Console.Write("Выходной");
        }
        else
        {
            Console.Write("Рабочий");
        }
    }
    else
    {
        Console.Write("Такого дня нет");
    }



