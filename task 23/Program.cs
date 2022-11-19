// Напишите программу которая принимает на вход число(N) и выдает
// таблицу кубов чисел от 1 до N
// 3 -> 1,8,27
// 5 -> 1,8,27,68,125

int number = 0;
while ( number < 1 )
{
    Console.Write("Введите положительное число: ");
    number = Convert.ToInt32(Console.ReadLine());
    if ( number < 1 ) 
    Console.WriteLine("Вы ввели неверное число \nПопробуйте еще раз");
}
void Cube ( int numA)
{
    int count = 1;
    while ( count <= numA)
    {
        Console.WriteLine($"{count}|{count * count * count }");
        count ++; 
    }
}
Cube(number);