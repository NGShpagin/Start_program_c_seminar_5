// Домашнее задание
// Задача 2.
// Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.

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

int Func(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0 || i == 0)
        {
            sum += arr[i];
        }
    }
    return sum;
}

int[] arr_1 = MassNums(4);
Print(arr_1);
Console.WriteLine($"Sum = {Func(arr_1)}");