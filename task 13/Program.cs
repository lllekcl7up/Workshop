// Напишите программу, которая выводит третью цифру заданного числа или сообщает что третьей цифры нет.

Console.WriteLine("Введите трёхзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int ShowThirdDigit(int num)
{
    int result = 0;
        if (num >= 100)
        {
            while (num > 999)
            {
            num = num / 10;
            }
            result = num % 10;
        }
    return result;
}
if (ShowThirdDigit(numberA) == 0)
{
Console.WriteLine("Третьей цифры нет");
}
else
{
Console.WriteLine($"Третья цифра: {ShowThirdDigit(numberA)}");
}