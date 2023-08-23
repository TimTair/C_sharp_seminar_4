// Напишите программу, которая принимает на вход число A и выдает сумму чисел от 1 до A. 

// Например:
// a = 5
// sum = 1 + 2 + 3 + 4 + 5

int GetSum (int N)
{
    int sum = 0;
    for (int i = 1; i <= N; i++)
    sum += i;  // sum = sum + i;
    return sum;
}

Console.Clear();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма от 1 до {number} равна {GetSum(number)}");