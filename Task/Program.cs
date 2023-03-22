// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int Enter(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int[] Array(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
        array[i] = new Random().Next(min, max + 1);
    return array;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

int SumOfOddIndecies(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            sum += array[i];
    return sum;
}

int length = Enter("Введите длину массива: ");
int min = Enter("Введите минимальное число массива: ");
int max = Enter("Введите максимальное число массива: ");
int[] arr = Array(length, min, max);
PrintArray(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях равна {SumOfOddIndecies(arr)}");