using System;
using static System.Console;

Clear();

WriteLine("День недели: ");
int a = int.Parse(ReadLine());

if (a < 1 && a > 7)
{
    WriteLine("Введён не корректный номер дня");
}
else
{
    if (a <=5 )
    {
        WriteLine($"{a}->Рабочий день");
    }
    else
    {
        WriteLine($"{a}->Выходной день");
    }
}
