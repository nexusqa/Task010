using System;
using static System.Console;

Clear();

WriteLine("Введите трёхзначное число: ");
int a = int.Parse(ReadLine());

WriteLine($"{a}->{a/10%10}");    