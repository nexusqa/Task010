﻿using System;

public class Answer
{
    public static void MultiplyIfPossible(int[,] matrixA, int[,] matrixB)
    { // Введите свое решение ниже
      if (matrixA.GetLength(1) != matrixB.GetLength(0))
      {
        System.Console.WriteLine("It is impossible to multiply.");
      }
      else
      {
        PrintMatrix(MatrixMultiplication(matrixA, matrixB));
      }
    }

    public static int[,] MatrixMultiplication(int[,] matrixA, int[,] matrixB)
    {  // Введите свое решение ниже
      int[,] matr = new int[matrixA.GetLength(0), matrixB.GetLength(1)];
      for (int i = 0; i < matrixA.GetLength(0); i++)
      {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
          for (int k = 0; k < matrixA.GetLength(1); k++)
          {
            matr[i,j]+=matrixA[i,k]*matrixB[k,j];
          }
        }
      }
      return matr;
    }

    public static void PrintMatrix(int[,] matrix)
    {  // Введите свое решение ниже
    for (int i = 0; i < matrix.GetLength(0); i++)
      {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        System.Console.Write($"{matrix[i,j]}\t");
      }
      System.Console.WriteLine();
      }
    }
 // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[,] matrix;

        if (args.Length == 0)
        {
            // Если аргументы не переданы, используем матрицу по умолчанию
            matrix = new int[,]
            {
                {2, 4},
                {1, 3},
                {5, 6}
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
        PrintMatrix(matrix);

        int[,] matrixB = {
            {5, 6},
            {7, 8},
        };

        Console.WriteLine("\nMatrix B:");
        PrintMatrix(matrixB);

        Console.WriteLine("\nMultiplication result:");

        MultiplyIfPossible(matrix, matrixB);
    }
}