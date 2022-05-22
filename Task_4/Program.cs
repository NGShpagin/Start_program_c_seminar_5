// Задача 3. Решение в группах задач.
// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10, 99].

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
        arr[i] = new Random().Next(0, 124);
    }
    return arr;
}

void SearchNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99) 
        {
            count++;
        }
    }
    Console.WriteLine($"Count = {count}");
}

int[] arr_1 = MassNums(12);
Print(arr_1);
SearchNumber(arr_1);