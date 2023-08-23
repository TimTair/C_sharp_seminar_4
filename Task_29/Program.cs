// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


// int[] Array = new int [8];
// Random rnd = new Random();

// for (int i = 0; i < 8; i++)
// {
//     Array[i] = rnd.Next(0,100);
//     Console.Write($"{Array[i]}");
// }

// Console.WriteLine();



int[] Array = GetArray(8);

Console.WriteLine($"[{String.Join(", ", Array)}]");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 100);
    }
    return result;
}
