// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int Enter(string message)
{
    Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}
double[] Array(int length, int min, int max)
{
    double[] array = new double[length];
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round((new Random().Next(min, max + 1) * new Random().NextDouble()), 2);
    return array;
}

void PrintArray(double[] array)
{
    foreach (double item in array)
        Console.Write($"{item} ");
    Console.WriteLine();
}

double Difference(double[] array)
{
    int i = 0;
    double max = array[i];
    double min = array[i];
    double result = 0;
    for (i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
        else if (array[i]<min)
            min = array[i];
        result = Math.Round((max - min), 2);
    }
    return result;
}

try
{
int length = Enter("Введите длину массива: ");
int min = Enter("Введите минимальное число массива: ");
int max = Enter("Введите максимальное число массива: ");
double[] arr = Array(length, min, max);
PrintArray(arr);
Console.WriteLine($"Разница между самым большим и самым маленьким элементами массива равна {Difference(arr)}");
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}