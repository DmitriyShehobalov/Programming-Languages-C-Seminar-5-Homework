// Задача 34: 
// 1.Задайте массив заполненный случайными положительными трёхзначными числами.
// 2. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

int GetPositiveNumberArray(int[] array)
{
    int positiveNumber = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) positiveNumber = positiveNumber + 1;
    }
    return positiveNumber;
}
int[] arr = CreateArrayRndInt(7, 100, 999);
PrintArray(arr);
int positiveNumber = GetPositiveNumberArray(arr);
Console.WriteLine($"Количество чётных чисел в массиве-> {positiveNumber}");