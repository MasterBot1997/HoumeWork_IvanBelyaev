// Задача 25: 
// 1. Напишите цикл, который 
// 2. принимает на вход два числа (A и B) и 
// 3. возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А и В");
Console.Write("Число А = ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Число В = ");
int b = Convert.ToInt32(Console.ReadLine());

int NumStep(int numA, int numB)
{
    int sum = 1;
    for (int i = 1; i <= numB; i++)
    {
        sum *= numA;
    }
    return sum;

}

if (a < 0) Console.Write("Число А не является натуральным");
if (b < 0) Console.Write("Число В не является натуральным"); 
else
{
    int result = NumStep(a, b);
    Console.WriteLine(result);
}