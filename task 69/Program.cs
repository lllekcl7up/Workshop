// Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

  int DegreeNumber(int number, int degree)
{
    if (degree == 0) return 1;
    return DegreeNumber(number, degree - 1) * number;
}
int degreeNum = DegreeNumber(numberA,numberB);
Console.Write($"{degreeNum}");

// int PowerMath(int number, int degree)
// {
//     if (degree == 0) return 1;
//     else if ( degree % 2 == 0) return PowerMath( number * number, degree/2);
//     else return PowerMath(number , degree -1 ) * number;
// }
// int degreeNum = PowerMath(numberA,numberB);
// Console.Write($"{degreeNum}");






