// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе.
// 452 -> 11 
// 82 -> 10

int SumDigits( int num )
{
    int sum = default; 
    if (num < 0 )
    num = num * -1;
    for ( int i = 0; num > 0; i++)
    {
        sum = sum + num % 10;
        num =num / 10;
    }
    return sum;
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Сумма цифр числа {number} = {SumDigits(number)}");