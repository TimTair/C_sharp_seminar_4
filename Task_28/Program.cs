// Напишите программу, которая принимает на вход число N и выдает произведения чисел от 1 до N. 

// 4 -> 24
// 5 == 1 * 2 * 3 * 4 * 5

int ResultNumbers (int N)
{
    int sum = 1;
    for (int i = 1; i <= N; i++)
    sum = sum * i;
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int result = int.Parse(Console.ReadLine());
Console.WriteLine($"Прозведение чисел от 1 до {result} равно: {ResultNumbers(result)}");

