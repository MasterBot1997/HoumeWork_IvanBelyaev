// Задача 27: Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumber(int num)
{
    num = Math.Abs(num);
    int k = 0;
    while (num > 0)
    {
        k = k + num%10;
        num = num/10;
    }
    return k;
}

int result = SumNumber(n);
Console.Write($"Сумма цифр в числе {n} = {result}");