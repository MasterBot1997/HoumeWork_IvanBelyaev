// Задача 15: Напишите программу, которая 
// принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

// Вариант без метода

// Console.Write("Введите номер дня недели: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number == 1 ||number == 2 ||number == 3 ||number == 4 ||number == 5) Console.WriteLine("Нет");
// else if (number == 6 || number == 7) Console.WriteLine("Да");
// else Console.WriteLine("Упс! В неделе только 7 дней-_-. Другие числа не соответствуют требования");


//  Пробовал как и в 13 задаче сделать через метод, но я не понял как правильно 
// задать метод, выдает ошибку и я смотрел на офиц сайте ее значение но не понял
// в чем корень проблемы. 

bool DayOfWeek(int num)
{
    if (num == 6 || num == 7) return true;
    return false;

}

Console.Write("Введите номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

bool result = DayOfWeek(number);
if (result) Console.WriteLine("Да");
else if (number < 0 || number > 7)
{
    Console.WriteLine("Такого дня недели нет");
}
else if (number > 0 && number < 6)
{   
  Console.WriteLine("Нет");
}