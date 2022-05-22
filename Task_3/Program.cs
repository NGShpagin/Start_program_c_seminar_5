// Задача 2. Решение в группах задач.
// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

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

void SearchNumber(int[] arr, int num)
{
    
    string flag = "no"; 
    int index = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num) 
        {
            index = i;
            flag = "yes";
            break;
        }
    }
    Console.WriteLine($"Flag - {flag}, index = {index}");
}

int[] arr_1 = MassNums(6);
Print(arr_1);
SearchNumber(arr_1, 4);