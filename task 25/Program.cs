// Напишите цикл, который принимает на вход два числа ( А и В ) и возводит 
// число А в натуральную степень В.

int Degree( int a, int b)
{
    int degreeNum = 1;
    for ( int i = 1; i <= b; i++ )
    {
        degreeNum = degreeNum * a;
    }
        return degreeNum;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberB < 0 )
{
    Console.WriteLine("Вы ввели отрицательное число");
}
else
Console.WriteLine($"Число {numberA} в степени {numberB} = {Degree (numberA, numberB) }");