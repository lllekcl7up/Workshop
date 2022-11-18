//Напишите программу,которая принимает на вход координаты точки (X и Y), причем 
// X ≠ 0 и Y ≠ 0 и выдает номер четверти плоскости в которой находится эта точка.


Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int y = Convert.ToInt32(Console.ReadLine());

int Quarter (int xcoordinate, int ycoordinate) // названия переменных в МЕТОДЕ не должны быть совпадать с глобальными названиями 
{
    if ( xcoordinate > 0 && ycoordinate > 0 ) return 1;
    if ( xcoordinate < 0 && ycoordinate > 0 ) return 2;
    if ( xcoordinate < 0 && ycoordinate < 0 ) return 3;
    if ( xcoordinate > 0 && ycoordinate < 0 ) return 4;
    return 0; // нужно обязательно возвращать ноль чтобы QUARTER не ругался если ни одно из условий не будет выполнено
}

int quarter = Quarter(x, y);
string result = quarter > 0 
    ? $"Указанные координаты соответсвтуют четверти -> {quarter}" 
    : "Введены некорректные координаты";
Console.WriteLine(result);
