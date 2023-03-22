// Задача HARD STAT необязательная: Задайте массив случайных целых чисел.
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, среднее арифметическое всех элементов. 
// Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , возможно придется кое-что для этого дополнительно выполнить.

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

string Max(int[] array)
{
    string result = string.Empty;
    int indexMax = 0;
    int max = array[indexMax];
    for (int index = 0; index < array.Length; index++)
        if (array[index] > max)
        {
            max = array[index];
            indexMax = index;
        }
    result = $"Максимальный элемент массима {max}, а его индекс {indexMax}";
    return result;
}

string Min(int[] array)
{
    string result = string.Empty;
    int indexMin = 0;
    int min = array[indexMin];
    for (int index = 0; index < array.Length; index++)
        if (array[index] < min)
        {
            min = array[index];
            indexMin = index;
        }
    result = $"Минимальный элемент массима {min}, а его индекс {indexMin}";
    return result;
}

string Average(int[] array)
{
    string result = string.Empty;
    double sum = 0;
    foreach (int item in array)
        sum += item;
    double average = Math.Round((sum / array.Length), 2);
    result = $"Среднне арифметическое всех элементов массива равно {average}";
    return result;
}

void ArraySecond(string max, string min, string average)
{
    string[] array = { max, min, average };
    foreach (string item in array)
        Console.WriteLine(item);
}

int[] Sort(int[] array)
{
    int[] result = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
            if (array[j] < array[minPosition])
                minPosition = j;
        int temp = array[i];
        result[i] = array[minPosition];
        array[minPosition] = temp;
    }
    return result;
}

double Median(int[] array)
{
    double result;
    int length = array.Length;
    int indexMid = length / 2;
    if (length % 2 != 0)
        result = array[indexMid];
    else
        result = (array[indexMid - 1] + array[indexMid]) / 2;
    return result;
}

try
{
int length = Enter("Ввдеите длину массива: ");
int min = Enter("Введите минимально возможное значение для элементов массива: ");
int max = Enter("Введите максимально возможное значение для элементов массива: ");
int[] arr = Array(length, min, max);
PrintArray(arr);
ArraySecond(Max(arr), Min(arr), Average(arr));
int[] sort = Sort(arr);
PrintArray(sort);
Console.WriteLine($"Медианное значение первоначального массива {Median(sort)}");
}
catch
{
    Console.WriteLine("Введено некорректное значение");
}