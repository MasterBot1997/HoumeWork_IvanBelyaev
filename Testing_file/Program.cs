// Файл для того что бы пробовать команды

// int n = 12321;

// int Num1(int num1)
// {
//     int m1 = num1 / 1000 % 10 * 10 + n / 10000;
//     return m1;
// }
// int res1 = Num1(n);

// int Num2(int num2)
// {
//     int m2 = (num2 % 100 / 10 + n % 10 * 10)*1000;
//     return m2;
// }
// int res2 = Num2(n);

// int Num3(int num3)
// {
//     int m3 = num3 / 100 % 10 * 100;
//     return m3;
// }
// int res3 = Num3(n);

// int z = res1 + res2 + res3;
// Console.Write($"{z}");

// Console.Write("Напишите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// Это подойдет для сравнения суммы 2-х первых 
//и 2-х последних цифр пятизначного числа


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

// int result1 = NumberA(n);
// int result2 = NumberB(n);

// Console.Write($"{result1} = {result2}");

// 12321
// Console.Write("Напишите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// int Digit(int num)
// {
//     int a = num / 1000 % 10 * 10 + n / 10000;
//     int b = (num % 100 / 10 + n % 10 * 10) * 1000;
//     int c = num / 100 % 10 * 100;
//     int d = a + b + c;
//     return d;
// }

// int result = Digit(n);
// Console.WriteLine($"{result}");