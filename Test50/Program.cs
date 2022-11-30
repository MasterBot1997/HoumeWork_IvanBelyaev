// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5} |");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}

void SearchNumber(int[,] matr, int index1, int index2)
{
    if(index1 < 0 || index2<0) Console.WriteLine($"{index1}, {index2} -> Ой ей, такой ячейки не существует =(");
    else if (index1 < matr.GetLength(0))
    {
        if (index2 < matr.GetLength(1)) Console.Write(matr[index1, index2] + " -> Интересующее тебя число)");
        
        else Console.WriteLine($"{index1}, {index2} -> Ой ей, такой ячейки не существует =(");
    }
    else Console.WriteLine($"{index1}, {index2} -> Ой ей, такой ячейки не существует =(");
}


Console.Write("Привет, друг! Хочешь узначть, что находиться в интересующей тебя ячейке массива?");
Console.Write("Тогда введи номер интересующей строки - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("И номер интересующего столбца - ");
int b = Convert.ToInt32(Console.ReadLine());

int[,] array2D = CreateMatrixRndInt(5, 5, -100, 100);
PrintMatrix(array2D);
SearchNumber(array2D, a, b);