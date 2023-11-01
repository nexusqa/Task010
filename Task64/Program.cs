using System;
using static System.Console;

Clear();

WriteLine("Введите число M: ");
int N = int.Parse(ReadLine());
WriteLine("Введите число N: ");
int M = int.Parse(ReadLine());

for (int i = N; i <= M; i++)
{
    Write($"{i} ");
}