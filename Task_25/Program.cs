﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Clear();

Console.WriteLine("Введите первое число A: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число B: ");
int B = int.Parse(Console.ReadLine());

int Sum = A;

for (int i = 1; i < B; i++)
{
    Sum = Sum * A;
}

Console.WriteLine($"Число {A} в степени {B} равно: {Sum}");


