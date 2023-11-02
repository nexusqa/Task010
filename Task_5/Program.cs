using System;

public class Answer
{
    public static int SumOfRow(int[,] matrix, int row)
    {
// Введите свое решение ниже
      int summS = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          if (row == i)
          {
            summS+=matrix[i,j];          
          }
        }
      }
      return summS;
    }

    public static int[] MinimumSumRow(int[,] matrix)
    {
// Введите свое решение ниже
      int[] matr = new int[2];
      int summ = 0;
      for (int i = 0; i < matrix.GetLength(0); i++)
      {
        summ = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
          summ+=matrix[i,j];
        }
        if ((matr[1] == 0) || (summ < matr[1]))
        {
          matr[0] = i;
          matr[1] = summ;
          summ = 0;
        }
      }
      return matr;
    }

 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;
        if (args.Length == 0)
        {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
          // Если аргументы не переданы, используем матрицу по умолчанию
            
            matrix = new int[,]
            {
                {9, 1, 7},
                {1, 2, 3},
                {4, 5, 6}
            };
        }
        else
        {
            // Иначе, парсим аргументы в двумерный массив
            string[] rows = args[0].Split(';');
            matrix = new int[rows.Length, rows[0].Split(',').Length];
            for (int i = 0; i < rows.Length; i++)
            {
                string[] elements = rows[i].Split(',');
                for (int j = 0; j < elements.Length; j++)
                {
                    if (int.TryParse(elements[j], out int number))
                    {
                        matrix[i, j] = number;
                    }
                    else
                    {
                        Console.WriteLine($"Ошибка при парсинге аргумента {elements[j]}.");
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Исходная матрица:");
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]}\t");
            }
            Console.WriteLine();
        }

        int[] minSumRow = MinimumSumRow(matrix);

        Console.WriteLine($"\nСумма наименьшей строки (строка {minSumRow[0] + 1}): {minSumRow[1]}");

        int rowToSum = 1; 
        int sum = SumOfRow(matrix, rowToSum);
        Console.WriteLine($"Сумма элементов в строке {rowToSum + 1}: {sum}");
    }
}