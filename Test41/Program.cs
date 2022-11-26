// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int[] NameArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write(array[i] + ",");
        else Console.Write(array[i]);
    }
    Console.Write("]");
}

int ArrayNumberMoreThenZero(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count = count + 1;
    }

    return count;
}


Console.WriteLine("Введите количество элементов массива М: ");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите числа которые вы хотиите внести в массив: ");

int[] nameArray = NameArray(numM);
Console.Write("Ваш массив -> ");
PrintArray(nameArray);
int arrayNumberMoreThenZero = ArrayNumberMoreThenZero(nameArray);
Console.WriteLine($" - количество значений больше 0 = {arrayNumberMoreThenZero}");