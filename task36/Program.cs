// Задача 36: 
// 1.Задайте одномерный массив, заполненный случайными числами.
//  2.Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int SumElementsArray(int[] array)
{
    int sum = 0;


    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum = sum + array[i];
    }
    return sum;
}

int[] arr = CreateArrayRndInt(10, -100, 100);
PrintArray(arr);
int sum = SumElementsArray(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sum}");