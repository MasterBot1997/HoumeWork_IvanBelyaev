// Файл для того что бы пробовать команды

// int n = 12321;

// int Num1(int num1)
// {
//     int m1 = num1 / 1000 % 10 * 10 + n / 10000;
//     return m1;
// }
// int res1 = Num1(n);

// int Num2(int num2)
// {
//     int m2 = (num2 % 100 / 10 + n % 10 * 10)*1000;
//     return m2;
// }
// int res2 = Num2(n);

// int Num3(int num3)
// {
//     int m3 = num3 / 100 % 10 * 100;
//     return m3;
// }
// int res3 = Num3(n);

// int z = res1 + res2 + res3;
// Console.Write($"{z}");

// Console.Write("Напишите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Это подойдет для сравнения суммы 2-х первых 
// и 2-х последних цифр пятизначного числа


// int NumberA(int num1)
// {
//     int a = num1 / 10000 + num1 / 1000 % 10;
//     return a;
// }

// int NumberB(int num2)
// {
//     int b = num2 % 100 / 10 + num2 % 10;
//     return b;
// }

// int result1 = NumberA(n);
// int result2 = NumberB(n);

// Console.Write($"{result1} = {result2}");

// 12321
// Console.Write("Напишите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Digit(int num)
// {
//     int a = num / 1000 % 10 * 10 + n / 10000;
//     int b = (num % 100 / 10 + n % 10 * 10) * 1000;
//     int c = num / 100 % 10 * 100;
//     int d = a + b + c;
//     return d;
// }

// int result = Digit(n);
// Console.WriteLine($"{result}");

// Для домашки
// int[] CreateArrayRndint(int size, int min, int max)
// {
// int[] array = new int[size];
// Random rnd = new Random();
// for (int i = 0; i < size; i++)
// {
// array[i] = rnd.Nextint() * (max - min) + min;
// }
// return array;
// }

// Рандом массив дабл с округлением
// int[] CreateArrayRndint(int size, int min, int max)
// {
// int[] array = new int[size];
// Random rnd = new Random();
// for (int i = 0; i < size; i++)
// {
// int num = rnd.Nextint() * (max - min) + min;
// array[i] = Math.Round(num, 1);
// }
// return array;
// };

// ------------------------------------------------------------------------------------
// Создание массива с определением размера пользоватеелем и заполнением пользователем

// Console.WriteLine("Введите количество элементов массива : ");
// int num = Convert.ToInt32(Console.ReadLine());

// int[] NameArray(int size)
// {
//  int[] array = new int[size];
//     for (int i = 0; i < array.Length; i++)
//     {
//        array[i] = Convert.ToInt32(Console.ReadLine());
//     }

//     return array;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write(array[i] + ",");
//         else Console.Write(array[i]);
//     }
//     Console.Write("]");
// // }

// // int[] nameArray = NameArray(num);
// // PrintArray(nameArray);
// // :::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(0); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],2} |");
// //             else Console.Write($"{matrix[i, j],2}");
// //         }
//         Console.WriteLine(" |");
//     }
// }


// void PrintArray(int[] array)
// // {
// //     Console.Write("[");
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if (i < array.Length - 1) Console.Write($"{array[i]},");
// //         else Console.Write($"{array[i]}");
// //     }
// //     Console.WriteLine("]");
// // }

// // int[,] array2D = CreateMatrixRndInt(4, 1, 1, 5);
// // PrintMatrix(array2D);
// // int[] arr = CreateArrayRndInt(array2D);
// // PrintArray(arr);

// // int[] array = new int[array2D.GetLength(1)];

// for (int i = 0; i < array2D.GetLength(1); i++)
// {
//     int midSum = 0;
//     for (int j = 0; j < array2D.GetLength(1); j++)
//     {
//         int sum = 0;
//         for (int k = 0; k < array2D.GetLength(0); k++)
//         {
//             sum = array2D[k, j] + sum;
//             Console.Write($"{sum}");
//         }
//         midSum = sum / array2D.GetLength(0);
//        array[i] = Math.Round(midSum, 2);
//     }
// }
//
//================================================================================

// int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth, int min, int max)
// {
//     int[,,] matrix = new int[rows, columns, depth];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = rnd.Next(min, max + 1);
//             }

//         }
//     }
//     return matrix;
// }

// void PrintMatrix3D(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {

//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j, k],3} ");
//                 else Console.Write($"{matrix[i, j, k],3}");
//             }

//         }
//         Console.WriteLine(" |");
//     }
// }

// int[,,] matrix3D = CreateMatrix3DRndInt(3, 3, 3, 1, 10);
// PrintMatrix3D(matrix3D);

//================================================================

// int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }

//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("|");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}|");
//             else Console.Write($"{matrix[i, j],3}");
//         }
//         Console.WriteLine(" |");
//     }
// }

// int[] maxNumber1(int[,] matrix)
// {
//     int[] max = new int[matrix.GetLength(1)];
//     for (int i = 0; i < matrix.GetLength(1); i++)
//     {
//         max[i] = matrix[0, i];
//     }
//     return max;
// }

// void PrintArray(int[] array)
// {
//     Console.Write("[");
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.Write($"{array[i]},");
//         else Console.Write($"{array[i]}");
//     }
//     Console.WriteLine("]");
// }

// void Sort(int[] sort)
// {
//     int temp = default;
//     for (int i = 0; i <= sort.Length - 1; i++)
//     {
//         for (int j = 0; j <= sort.Length - 2; j++)
//         {
//             if (sort[j] < sort[j + 1])
//             {
//                 temp = sort[j];
//                 sort[j] = sort[j + 1];
//                 sort[j + 1] = temp;
//             }
//         }
//     }
// }

// int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
// PrintMatrix(array2D);
// int[] array1 = maxNumber1(array2D);
// Console.WriteLine();
// PrintArray(array1);
// Sort(array1);
// Console.WriteLine();
// PrintArray(array1);
//=================================================================================

//Шаблон заполнения трехзначной матрицы с прибавление каждщго следующего числа на 1

// int[,,] CreateMatrix3DRndInt(int rows, int columns, int depth)
// {
//     int[,,] matrix = new int[rows, columns, depth];
//     int n = 10;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 matrix[i, j, k] = matrix[i, j, k] + n;
//                 n++;
//             }
//         }
//     }
//     return matrix;
// }

// void PrintMatrix3D(int[,,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         Console.Write("");
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             for (int k = 0; k < matrix.GetLength(2); k++)
//             {
//                 if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k]}({i,1},{j,1},{k,1}) ");
//                 else Console.Write($" {matrix[i, j, k]}({i,1},{j,1},{k,1}) ");
//             }
//         }
//         Console.WriteLine("");
//     }
// }


//     int[,,] matrix3D = CreateMatrix3DRndInt(a, b, c);
//     PrintMatrix3D(matrix3D);