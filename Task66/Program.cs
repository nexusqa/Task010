using System;
using static System.Console;

Clear();

WriteLine("Введите число M: ");
int N = int.Parse(ReadLine());
WriteLine("Введите число N: ");
int M = int.Parse(ReadLine());

int summ = 0;

for (int i = N; i <= M; i++)
{
    summ+=i;
}

WriteLine($"Сумма чисел от {N} до {M} равна {summ}");