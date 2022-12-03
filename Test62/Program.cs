// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.

// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateMatrixRndInt(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];
    int count = 1;
    int sC = 0;
    int eC = columns - 1;
    int sR = 0;
    int eR = rows - 1;

    while (sC <= eC && sR <= eR)
    {
        for (int i = sC; i <= eC; i++)
        {
            matrix[sR, i] = count;
            count++;
        }
        sR++;

        for (int j = sR; j <= eR; j++)
        {
            matrix[j, eC] = count;
            count++;
        }
        eC--;
        for (int k = eC; k >= sC; k--)
        {
            matrix[eR, k] = count;
            count++;
        }
        eR--;
        for (int z = eR; z >= sR; z--)
        {
            matrix[z, sC] = count;
            count++;
        }
        sC++;
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


int[,] array2D = CreateMatrixRndInt(4, 3);
PrintMatrix(array2D);