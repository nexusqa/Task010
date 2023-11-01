using System;

public class Answer
{
    public static double FindMax(double[] array)
    {     // Введите свое решение ниже
       double maxS = array[0];
       for (int i = 0; i < array.Length; i++)
       {
         if (maxS < array[i])
         {
           maxS = array[i];
         }
       }
      return maxS;

       
    }

    public static double FindMin(double[] array)
    {     // Введите свое решение ниже
       double minS = array[0];
       for (int i = 0; i < array.Length; i++)
       {
         if (minS > array[i])
         {
           minS = array[i];
         }
       }
      return minS;


    }

    public static double CalcDifferenceBetweenMaxMin(double[] array)
    {// Введите свое решение ниже
      double maxS = array[0];
      double minS = array[0];
      for (int i = 0; i < array.Length; i++)
      {
        if (maxS < array[i]) maxS = array[i];
        if (minS > array[i]) minS = array[i];
      }
      double dif = maxS - minS;
      return dif;


    }

    public static void PrintArray(double[] array)
    {// Введите свое решение ниже
      System.Console.WriteLine($"{String.Join("\t",array)}");  

    }
 // Не удаляйте и не меняйте метод Main! 


    public static void Main(string[] args)
    {
        double[] array;
        if (args.Length == 0)
        {
            array = new double[] { 3.17, 8.94, 2.36, 5.72, 0.85 };
        }
        else
        {
            // Иначе, парсим аргументы в массив чисел
            string[] argStrings = args[0].Split(", ");
            array = new double[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (double.TryParse(argStrings[i], out double number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        Console.WriteLine("Массив:");
        PrintArray(array);
        double diff = CalcDifferenceBetweenMaxMin(array);
        Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff:f2}");
    }
}