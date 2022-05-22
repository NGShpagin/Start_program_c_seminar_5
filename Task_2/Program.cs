// Задача 1. Решение в группах задач.
// Напишите программу замены элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

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
    }
    return arr;
}

void ChangeNums(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] arr_1 = MassNums(4);
Print(arr_1);
ChangeNums(arr_1);
Print(arr_1);