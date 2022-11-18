// Напишите программу, которая принимает на вход число (N) и выдает
// таблицу квадратов чисел от 1 до N.

// Console.WriteLine("Введите число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// void Square(int num)
// {
//     for (int i = 1; i <= num; i++)
// {
//         Console.WriteLine($"{i} -> {i * i} ");
// }
// }
// Square(number);


int n = -1; // Сделали переменную меньше 1 
while (n < 1) // до тех пор пока N не будет больше одного
{
    Console.WriteLine("Введите положительное число");
    n = Convert.ToInt32(Console.ReadLine());
    if ( n < 1 ) Console.WriteLine("Вы ввели неверное число");
}

string SqrTable(int num)
{
    int count = 1;
    string table = "";
    while (count <= num)
    {
        table = table + $"{count}|{count * count} \n";
        count ++;
    }
    return table;
}
string sqrTable = SqrTable(n);
Console.WriteLine(sqrTable);
