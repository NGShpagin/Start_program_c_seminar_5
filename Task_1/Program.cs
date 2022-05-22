// Задача 1. Демонстрация решения
// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

void Print(int[] arr)
{
    int size = arr.Length;
    for (int i = 0; i < size; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

int[] MassNums(int size)
{
    int[] arr = new int[size];

    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(-9, 10);
        Console.Write($"{arr[i]}, ");
    }
    return arr;
}

void SumMaxMin(int[] arr)
{
    int s_min, s_max;
    s_min = s_max = 0;

    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= 0)
        {
            s_max += arr[i];
        }
        else
        {
            s_min += arr[i];
        }
    }
    Console.WriteLine($"sum positive = {s_max}, sum negative = {s_min}");
}

int[] arr_1 = MassNums(12);
Print(arr_1);
SumMaxMin(arr_1);
int[] arr_2 = MassNums(12);
Print(arr_2);
SumMaxMin(arr_2);