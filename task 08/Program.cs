// Напишите программу, которая на вход принимает число(N), а на выход показывает все чётные числа от 1 до N/

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
int x = 2;

while (numberA >= x)
{
    Console.Write($" {x} ");
    x = x + 2;
}
