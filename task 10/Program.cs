// Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трёхзначное число: ");
int numberA = Convert.ToInt32(Console.ReadLine());

int ShowSecondDigit(int num)
{
    int Digit = num / 10 % 10;
    int result = Digit;
    return result;
}

Console.WriteLine($"Вторая цифра = {ShowSecondDigit(numberA)}");