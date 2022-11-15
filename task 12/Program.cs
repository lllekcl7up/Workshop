// 12. Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если число 1 не кратно числу 2, то
// программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

// Console.WriteLine("Введите первое число: ");
// int numberA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите второе число: ");
// int numberB = Convert.ToInt32(Console.ReadLine());
// int ostatok = numberA % numberB;

// if (ostatok == 0)
// {
// Console.WriteLine("Первое число кратно второму");
// }
// else
// {
// Console.WriteLine("Число 1 не кратно числу 2, остаток " +ostatok);
// }


Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int numberB = Convert.ToInt32(Console.ReadLine());

bool Multiplicity (int num1, int num2)
{
     return num1 % num2 == 0;
}

// int MultiplicitySecond (int number1, int number2)
// { 
//     return number1 % number2;
// }

bool result = Multiplicity(numberA, numberB);
Console.WriteLine(result ? "Первое число кратно второму" : $"Некратно, остаток = {numberA % numberB}" );

// int result2 = MultiplicitySecond(num1, num2);
// Console.WriteLine(result2 == 0 ? "Первое число кратно второму" : $"Некратно, остаток = {result2}" );