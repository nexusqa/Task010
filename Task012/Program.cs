using System;
using static System.Console;

Clear();

WriteLine("Введите число: ");
int a = int.Parse(ReadLine());

if (a < 100)
{
    WriteLine("Третьей цифры нет");
}
else    
{
   if (a > 999)
   {
    int b = a;
    while (b > 999)
    {
        b = b/10;
    }
    WriteLine($"{a}->{b%10}");
   }
   else
   {
    WriteLine($"{a}->{a%10}");
   }

}