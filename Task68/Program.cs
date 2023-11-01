using System;
using static System.Console;

Console.Write("Введите число n: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите число m: ");
int b = int.Parse(Console.ReadLine());

int GetAkkerman(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0 && m > 0) return GetAkkerman(m - 1, 1);
    else
    {
    return GetAkkerman(m - 1, GetAkkerman(m, n - 1));
    } 
}


WriteLine(GetAkkerman(a,b));