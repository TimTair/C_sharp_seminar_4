// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumDigit (int N)
// {
//     int D = 0;
//     int result = 0;
//     for (int i = 0; N >= 0; i++)
//     D = N % 10; // D = 9012 % 10 = 2
//     N = N / 10; // N = 9012 / 10 = 901
//     result = result + D; // result = 0 + 2
//     return result;
// }

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int Sum = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр числа {Sum} равна: {SumDigit(Sum)}");


// Console.Clear();

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int result = 0;
// int D = 0;

// for (int i = 0; i <= number; i++)  // 1 < 123; 2 < 12; 3 < 1;
// {
//     D = number % 10;        // D = 1234 % 10 = 4;         D = 123 % 10 = 3;        D = 12 % 10 = 2;
//     number = number / 10;   // number = 1234 / 10 = 123;  number = 123 / 10 = 12;  number = 12 / 10 = 1;
//     result = result + D;    // result = 0 + 4 = 4;        result = 4 + 3 = 7;      result = 7 + 2 = 9;
// }

// Console.WriteLine($"Сумма цифр равна: {result}");



Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
int result = 0;
int D = 0;

while (number > 0)
{
    D = number % 10;
    number = number / 10;
    result = result + D;
}

Console.WriteLine($"Сумма цифр равна: {result}");

