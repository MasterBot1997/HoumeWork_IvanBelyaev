// Задача 43: Напишите программу, которая найдёт точку 
// пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double CoordinateY(double numB1, double numK1, double numB2, double numK2)
{
    double y = (numB1 * numK2 - numK1 * numB2)/(numK2 - numK1);
    Math.Round(y, 2);
    return y;
}

double CoordinateX(double numB1, double numK1, double numB2, double numK2)
{
    double x = ((numB2 - numB1) / (numK1 - numK2));
    Math.Round(x, 2);
    return x;
}

Console.WriteLine("Укажите Значения b1, k1, b2, k2: ");
Console.Write("b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());

double coordinateY = CoordinateY(b1, k1, b2, k2);
double coordinateX = CoordinateX(b1, k1, b2, k2);
Console.Write($"Координаты (X ; Y) -> ({coordinateX} ; {coordinateY})");



