// Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.
// A(3,6); B(2,1) -> 5.9
// A(7,-5); B(1,-1) ->7,21

Console.Write("Введите координату точки Xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Yb: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distanse( int XA, int YA, int XB, int YB)
{
    double XC = ( XA - XB ) * ( XA - XB );
    double YC = ( YA - YB ) * ( YA - YB );
    double result = Math.Sqrt( XC + YC );
    return result;
}
double res = Distanse(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);