// Напишите программу, которая 
// 1. принимает на вход пятизначное число 
// 2. и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Напишите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());

int Digit(int num)
{
    int a = num / 1000 % 10 * 10 + n / 10000;
    int b = (num % 100 / 10 + n % 10 * 10) * 1000;
    int c = num / 100 % 10 * 100;
    int d = a + b + c;
    return d;
}

int result = Digit(n);
if (n < 10000 || n >= 100000) Console.WriteLine("Ввели число неподходящее под условие-_-! Повторите опытку.");
else if (n == result) Console.WriteLine($"{n} ->Даааа!");
else Console.WriteLine($"{n} -> Нет-_-");


// Подскажите что в этиом решении через 2 заданных метода можно подправить,
// что бы данное решение было рабочим для наших условий?

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

// int resultA = NumberA(n);
// int resultB = NumberB(n);
// if (n < 10000 || n >= 100000) Console.WriteLine("Ввели число неподходящее под условие-_-! Повторите опытку.");
// else if (resultA == resultB) Console.WriteLine($"{n} ->Даааа!");
// else Console.WriteLine($"{n} -> Нет-_-");
