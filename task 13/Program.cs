// Напишите программу, которая выводит третью цифру заданного числа или сообщает что третьей цифры нет.

Console.WriteLine("Введите трёхзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int ShowThirdDigit(int num)
{
    if (num < -99)
    {
        num = num * -1;
    }
    while (num > 999)
    {
        num = num / 10;
    }
    return num;
}
if (numberA > 99 || numberA < -99)
{
    Console.WriteLine($"Третья цифра: {ShowThirdDigit(numberA) % 10} ");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
