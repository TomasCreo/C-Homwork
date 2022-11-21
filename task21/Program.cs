// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите точку XА: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YА: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку ZА: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку ZB: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance (int xa, int ya, int za, int xb, int yb, int zb)
{
    double xc = (xa - xb)*(xa - xb);
    double yc = (ya - yb)*(ya - yb);
    double zc = (za - zb)*(za - zb);
    double res = Math.Sqrt(xc + yc + zc);
    return res;
} 
double result = Distance(xa, ya, za, xb, yb, zb); 
double resround = Math.Round(result, 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точками = {resround}");