// Напишите прогрмамму, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

// Я пытался вытащить метод из общей конструкции но у меня так 
// и не получилось. Решение большое и громоздкое но я для своего
// понимания расписывал работу строк что б получше понять как они
// работают. Без метода с циклом решение может быть компактнее.

// 1 решение 

//     Console.Write("Введите пятизначное число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
// if ( number > 10000 && number < 100000 )
// {
// void PolindromShow ( int num )
// {
// int firstDigit = num / 10000;
// int fiveDigit = num % 10;
// int secondDigit = num / 1000 % 10;
// int fourthDigit = num / 10 % 10;
//     if (firstDigit == fiveDigit && secondDigit == fourthDigit)
//     {
//         Console.WriteLine($"Число {number} является палиндром");
//     }
// else Console.WriteLine($"Число {number} не является палиндромом");
// }
// PolindromShow(number);
// }
// else  Console.Write("Вы ввели не пятизначное число");

// 2 решение

bool PolindromShow ( int num )
{
int firstDigit = num / 10000;
int fiveDigit = num % 10;
int secondDigit = num / 1000 % 10;
int fourthDigit = num / 10 % 10;
    return firstDigit == fiveDigit && secondDigit == fourthDigit;
  //   {
  //       return true;
  //   }
  //  else return false;
}
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if ( number > 10000 && number < 100000 )
{
   bool a = PolindromShow(number);
   Console.Write($"Это число {number} полиндром? - {a}");
}
else
{
  Console.Write("Вы ввели не пятизначное число");
}

// 3 решение (Решение группы)

// Console.WriteLine("Введите число ");
// int number = Convert.ToInt32(Console.ReadLine());

// int Reverse( int num)
// {
//     int result = 0;
//     while ( num != 0)// пока num не будет равно нулю выполняем следующий цикл
//     {
//         int ostatok;
//         num = Math.DivRem(num, 10, out ostatok);
//         result = result * 10 + ostatok;
//     }
//     return result;
// }
// int a = Reverse(number);
// Console.WriteLine(( a == number) ? "Yes it is Polindrom" : "No it is not");


// // Решение Владимира (разворот числа )

// Console.Write("Введите любое число:");
// int number = Convert.ToInt32(Console.ReadLine());

// int Palindrom(int num)
// {
//     if ( num > 9)
//     {
//         int number_digit = 0;// объявили переменные 
//         int reverse_digit = 0;// объявили переменные 
//         for ( int i = 0; num > 0; i++)
//         {
//             number_digit = num % 10;// получаем последнюю цифру числа
//             reverse_digit = (reverse_digit + number_digit) * 10; // тут разворачивается число
//             num = num / 10; // тут мы т основного числа отваливаев последнюю цифру.
//         }
//         reverse_digit = reverse_digit / 10;
//         return ( reverse_digit);
//     }
//     return (0);
// }
// Palindrom(number);
// if ( number == Palindrom(number))
// {
//       Console.Write("Число является палиндомом");
// }
// else if ( number < 10 )
//       Console.Write("Единичное число заведомо является палиндромом");
// else if ( number < 0 )
//       number = number * - 1;
// else 
// Console.Write("Число не является палиндромом");