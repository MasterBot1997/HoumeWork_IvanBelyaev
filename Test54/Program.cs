﻿// Задача 54: Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}|");
            else Console.Write($"{matrix[i, j],3}");
        }
        Console.WriteLine(" |");
    }
}

int[,] SortArray(int[,] matrix)
{
    int[,] newArr = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int min = matrix[i, j];
            if (j + 1 > matrix.GetLength(1))
            {
                if (min > matrix[i, j + 1])
                {
                    min = matrix[i, j + 1];
                    matrix[i, j + 1] = matrix[i, j];
                    matrix[i, j] = min;
                }
            }
            else newArr[i, j] = matrix[i, j];

        }

    }
    return newArr;
}



int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[,] newArray = SortArray(array2D);
PrintMatrix(newArray);