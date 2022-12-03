// Задача 60. ...Сформируйте трёхмерный 
// массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно
// выводить массив, добавляя индексы каждого элемента.


// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0, 0, 0) 27(0, 0, 1) 25(0, 1, 0) 90(0, 1, 1)
// 34(1, 0, 0) 26(1, 0, 1) 41(1, 1, 0) 55(1, 1, 1)

int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];
    int n = 10;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i, j, k] = matrix[i, j, k] + n;
                n++;
            }
        }
    }
    return matrix;
}

void PrintMatrix3D(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k]}({i,1},{j,1},{k,1}) ");
                else Console.Write($" {matrix[i, j, k]}({i,1},{j,1},{k,1}) ");
            }
        }
        Console.WriteLine("");
    }
}

Console.WriteLine("Введите количество строк матрицы: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов матрицы: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите глубину матрицы: ");
int c = Convert.ToInt32(Console.ReadLine());
if (a * b * c > 90) Console.WriteLine("Условие не может быть выполнено, не хватит неповторяющихс чсел");
else
{
    int[,,] matrix3D = CreateMatrix3DRndInt(a, b, c);
    PrintMatrix3D(matrix3D);
}