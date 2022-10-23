// Задача 10: Напишите программу, которая принимает на 
// вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа. Выполнить с помощью 
// числовых операций (целочисленное деление, остаток от деления).

// 456 -> 5
// 782 -> 8
// 918 -> 1

// Вариант где число задается рандомно
int number = new Random().Next(100, 1000);
Console.Write($"Введите трёхзначное число: {number} ");
// Вариант где число задает пользователь
// int number = Convert.ToInt32(Console.ReadLine());

//Решение с методом

// int DelSecondDigit(int num)
// {
//     int number1 = num / 10;
//     int number2 = number1 % 10;

//     return lastNumber;
// }
// int midNumber = DelSecondDigit(number);
// Console.WriteLine($"Число посередине = {midNumber} ");

// Через простое математическое выражение
int midNumber = number / 10 % 10;
Console.WriteLine($"Число посередине = {midNumber} ");
