// Домашнее задание
// Задача 3.
// Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементоми массива.

void Print(double[] arr)
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
    double[] arr = new double[size];
    Random n_new = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = Math.Round(n_new.NextDouble() * (10 + 12) - 10, 2);
    }
    return arr;
}

void MaxMin(double[] arr)
{
    double max = arr[0];
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > arr[max])
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