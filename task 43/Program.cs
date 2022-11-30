// Задача 43: Напишите программу, которая найдёт точку пересечения
//  двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Введите числo b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числo k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числo b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите числo k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());
double ba = b1;
double bb = b2;
double ka = k1;
double kb = k2;

double FindX (double ba, double bb, double ka, double kb)
{
    double x = (bb - ba)/(ka-kb);
    return x;    
}    

double FindY (double ba, double bb, double ka, double kb)
{
    double y =ka * (bb - ba)/(ka-kb) + ba;
    return y;    
} 

double findX = FindX(ba,bb,ka,kb);
double findY = FindY(ba,bb,ka,kb);

Console.WriteLine($"Две прямые пересекутся в точке с координатами X: {Math.Round(findX,2)} Y: {Math.Round(findY,2)}");