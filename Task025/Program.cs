// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

using System;
using static System.Console;

Clear();

int A = int.Parse(ReadLine());
int B = int.Parse(ReadLine());

WriteLine($"Число {A} в степени {B} равно {GetStepen(A,B)}");

int GetStepen(int x, int y)
{
    int num = Convert.ToInt32(Math.Pow(x, y));
    return num;
}