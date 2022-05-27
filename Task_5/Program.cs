// Задача 4. Решение в группах задач.
// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

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
        arr[i] = new Random().Next(0, 10);
    }
    return arr;
}

void SumNumbers(int[] arr)
{
    int mul = 0;
    int len = arr.Length - 1;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        mul = arr[i] * arr[len - i];
        Console.Write($"{mul} ");
    }
    if (arr.Length % 2 == 0) Console.WriteLine();
    else Console.WriteLine(arr[arr.Length / 2]);
}

int[] arr_1 = MassNums(9);
Print(arr_1);
SumNumbers(arr_1);