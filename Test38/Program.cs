// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным 
// и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        array[i] = Math.Round(num, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

double MaxNumber(double[] array)
{
    double max = array[0];
   for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double MinNumber(double[] arrayMin)
{
    double min = arrayMin[0];
   for (int i = 0; i < arrayMin.Length; i++)
    {
        if (arrayMin[i] < min) min = arrayMin[i];
    }
    return min;
}

double[] arr = CreateArrayRndDouble(6, -10, 10);
double maxNumber = MaxNumber(arr);
double minNumber = MinNumber(arr);
double result = maxNumber - minNumber;
PrintArray(arr);
Console.WriteLine($"max = {maxNumber}, min = {minNumber}");
Console.WriteLine($"max - min = {result}");

