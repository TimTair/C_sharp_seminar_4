// Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1, 0, 0, 1, 1, 0, 1, 1]



// int[] Array = new int[8];
// Random rnd = new Random(); 
// for (int i = 0; i < 8; i++)

// {
// Array[i] = rnd.Next(0,2);
// Console.Write($"{Array[i]} ");
// }
// Console.WriteLine();

Random rnd = new Random();

for (int i = 0; i < 8; i++)
{
    Console.WriteLine(rnd.Next(0, 2)); 
}


