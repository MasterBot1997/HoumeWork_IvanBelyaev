// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Akkerman(int numM, int numN)
{
    if (numM == 0) return numN + 1;
    if (numM > 0 && numN == 0) return Akkerman(numM - 1, 1);
    return Akkerman(numM - 1, Akkerman(numM, numN - 1));
}

Console.WriteLine("Введите два неотрицательных числа: ");
Console.Write("M = ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N = ");
int n = Convert.ToInt32(Console.ReadLine());

if (m < 0 || n < 0)
{
    Console.WriteLine("Вы ввели отрицательное(ые) число(а) -_-");
}
else
{
    int akkerman = Akkerman(m, n);
    Console.WriteLine($"M = {m}, N = {n} -> A(m,n) = {akkerman}");
}