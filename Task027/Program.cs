using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int x = int.Parse(ReadLine());

WriteLine($"Сумма чисел {x} равна {GetSummIn(x)}");




int GetSummIn(int number)
{
    int summ = 0;
    while(number != 0)
    {
        summ = summ + number%10;
        number = number/10;
    }
    return summ;

}