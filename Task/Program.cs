// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int CountEven(int[] array)
{
    int count = 0;
    foreach (int item in array)
        if (item % 2 == 0)
            count++;
    return count;
}

try
{
    Console.Write("Введите длину массива: ");
    int length = Convert.ToInt32(Console.ReadLine());
    if (length < 0)
        Console.WriteLine("Введена некоректная длина массива");
    else
    {
        int[] arr = new int[length];
        FillArray(arr);
        PrintArray(arr);
        Console.WriteLine($"Количество чётных чисел в массиве равно {CountEven(arr)}");
    }
}
catch
{
    Console.WriteLine("Введена некоректная длина массива");
}