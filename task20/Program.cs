// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите точку XА: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YА: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance (int xa, int ya, int xb, int yb)
{
    double xc = (xa - xb)*(xa - xb);
    double yc = (ya - yb)*(ya - yb);
    double res = Math.Sqrt(xc + yc);
    return res;
} 
double result = Distance(xa, ya, xb, yb); 
double resround = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine(resround);