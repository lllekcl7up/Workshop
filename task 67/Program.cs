// Задача 67: Напишите программу, которая будет принимать на вход число и
// возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumRecurs(int num)
{
    int sum = 0;
    if (num % 10 == 0) return sum;
    sum =  sum + num %10 + SumNumRecurs(num/10);
    return sum;
}
// int sumNum = SumNumRecurs(number);
// Console.WriteLine($"{sumNum}");
// Можно вызывать метод или так или так 
Console.WriteLine(SumNumRecurs(Math.Abs(number)));

// Вариант решения через торенарный оператор
// int SumDigits (int numb)
// {
//     return numb != 0 ? numb % 10 + SumDigits(numb/10) : 0;
// }
// Console.WriteLine(SumDigits(Math.Abs(number)));
