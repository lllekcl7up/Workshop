// Напишите программу, которая принимает на вход число (N) и выдает
// таблицу квадратов чисел от 1 до N.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square(int num)
{
    for (int i = 1; i <= num; i++)
{
        Console.WriteLine($"{i} -> {i * i} ");
}
}
Square(number);
