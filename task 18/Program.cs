// Напишите программу, которая по заданному номеру четверти, показывает 
// диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер четверти:");
string quarter = Console.ReadLine();

string Range (int quarter1) // тут мы через строку определяем а не через математические вычисления
{
    if (quarter1 == "1") return "x > 0 и y > 0";
    if (quarter1 == "2") return "x < 0 и y > 0";
    if (quarter1 == "3") return "x < 0 и y < 0";
    if (quarter1 == "4") return "x > 0 и y < 0";
    return "Введен неверный данные";
}
string range = Range(quarter);

Console.WriteLine(range);