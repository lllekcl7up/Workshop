// Напишите прогрмамму, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

// Я пытался вытащить метод из общей конструкции но у меня так 
// и не получилось. Решение большое и громоздкое но я для своего
// понимания расписывал работу строк что б получше понять как они
// работают. Без метода с циклом решение может быть компактнее.

    Console.Write("Введите пятизначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
if ( number > 10000 && number < 100000 )
{
void PolindromShow ( int num )
{
int firstDigit = num / 10000;
int fiveDigit = num % 10;
int secondDigit = num / 1000 % 10;
int fourthDigit = num / 10 % 10;
    if (firstDigit == fiveDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine($"Число {number} является палиндром");
    }
else Console.WriteLine($"Число {number} не является палиндромом");
}
PolindromShow(number);
}
else  Console.Write("Вы ввели не пятизначное число");
