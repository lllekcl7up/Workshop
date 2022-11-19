// Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстрояния между ними в 3D пространстве
//A (3,6,8) B(2,1,-7 ->15.84)
//A (7,-5,0) B(1,-1,9 ->11.53)
//

Console.Write("Введите координату точки Xa: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Ya: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Za: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Xb: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Yb: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки Zb: ");
int zb = Convert.ToInt32(Console.ReadLine());


double Distanse( int XA, int XB, int YA, int YB, int ZA, int ZB)
{
        double XC = ( XA - XB ) * ( XA - XB );
        double YC = ( YA - YB ) * ( YA - YB );
        double ZC = ( ZA - ZB ) * ( ZA - ZB );
        double result = Math.Sqrt( XC + YC + ZC );
        return result;
}
double resultBig = Distanse( xa, xb, ya, yb, za, zb );
double resultRound = Math.Round( resultBig, 2, MidpointRounding.ToZero);
Console.WriteLine(resultRound);