// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет. 
// Выполнить с помощью числовых операций (целочисленное 
// деление, остаток от деления).

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Найти 3 цифру этого числа: ");
int number = Convert.ToInt32(Console.ReadLine());

// int number = new Random().Next(100, 1000000000);
// Console.Write($"Введите трёхзначное число: {number} ");

if (number < 100)
{
    Console.Write($"Тут {number} нет третьего числа-_-");
}
else
{
    while (number > 1000)
    {
        number = number / 10;
        // Console.WriteLine($"{number}"); 
        //- использовал для проверки и поимания процесса
    }
    int needNum = number % 10;
    Console.Write($"Треть число:{needNum} ");
}
