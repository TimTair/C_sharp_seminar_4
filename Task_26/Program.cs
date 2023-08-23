// Напишите программу, которая принимает на вход число и выдает количество цифр в числе.

// 456 -> 3
// 78 -> 2
// 89126 -> 5


int CountNumbers (int n) 
{
    int count = 0;
    
    while (n != 0) 
    {
        n /= 10; 
        count ++; 
    }
    return count;
}

Console.Clear();
Console.WriteLine("Напишите число: ");
int s = int.Parse(Console.ReadLine());
Console.WriteLine($"Количество цифр = {CountNumbers(s)}");

