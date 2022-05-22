// Домашнее задание
// Задача 3.
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементоми массива.

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
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}

void MaxMin(int[] arr)
{
    int max = 0;
    int min = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>arr[max])
        {
            arr[max] = arr[i];
        }
        else if (arr[i] < arr[min])
        {
            arr[min] = arr[i];
        }
    }
    Console.WriteLine($"max = {arr[max]}, index = {max}");
    Console.WriteLine($"min = {arr[min]}, index = {min}");
    int result = arr[max] - arr[min];
    Console.WriteLine($"result = {result}");
}

int[] arr_1 = MassNums(7);
Print(arr_1);
MaxMin(arr_1);