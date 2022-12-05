// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturNum(int m, int n)
{
    if (m == n) return m;
    return m + NaturNum(m + 1, n);
}
Console.WriteLine("Введите 2 числа");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    int sumX = NaturNum(number1, number2);
    Console.Write($"Сумма чисел от {number1} до {number2} равна {sumX}");
}
else
{
    int sumX = NaturNum(number2, number1);
    Console.Write($"Сумма чисел от {number1} до {number2} равна {sumX}");
}