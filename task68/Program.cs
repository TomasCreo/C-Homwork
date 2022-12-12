// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());

int Akerman (int a, int b)
{ 
    if (a == 0) return b + 1;
    else if (b==0) return Akerman (a-1, 1);
    return Akerman( a - 1, Akerman (a, b-1));
}

int result = Akerman(num1, num2);
Console.WriteLine(result);
