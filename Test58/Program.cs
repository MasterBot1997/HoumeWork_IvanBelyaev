// Задача 58: Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] MatrixMultiplication(int[,] mat1, int[,] mat2)
{
    int[,] newMatrix = new int[mat1.GetLength(0), mat2.GetLength(1)];
    for (int i = 0; i < mat1.GetLength(0); i++)
    {
        for (int j = 0; j < mat2.GetLength(1); j++)
        {
            for (int k = 0; k < mat1.GetLength(1); k++)
            {
                newMatrix[i, j] = newMatrix[i, j] + mat1[i, k] * mat2[k, j];
            }
        }
    }
    return newMatrix;
}

Console.WriteLine("Количество столбцов первой матрицы должно быть равно количеству строк другой матрицы иначе будет неверно-_-");
int[,] matrix1 = CreateMatrixRndInt(4, 4, 1, 10);
int[,] matrix2 = CreateMatrixRndInt(2, 4, 1, 10);
Console.WriteLine("Первая матрица");
PrintMatrix(matrix1);
Console.WriteLine("Вторая матрица");
PrintMatrix(matrix2);
if (matrix1.GetLength(1) != matrix2.GetLength(0)) Console.WriteLine("Матрицы разного размера!");
else
{
    int[,] matrixMultiplication = MatrixMultiplication(matrix1, matrix2);
    Console.WriteLine("Результат произведения двух матриц");
    PrintMatrix(matrixMultiplication);
}
