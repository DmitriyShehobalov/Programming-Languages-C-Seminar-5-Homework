// Задача 38: 
// 1.Задайте массив вещественных чисел. 
// 2.Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}
double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble() * (max - min) + min;
        arr[i] = Math.Round(num, 1);
    }
    return arr;
}
double MinDigitArray(double[] array)
{
    double minDigit = array[0];
    for ( int i = 1; i < array.Length; i++)
    {
        if (array[i] < minDigit) minDigit = array[i];
    }
    return minDigit;
}
double MaxDigitArray(double[] array)
{
    double maxDigit = array[0];
    for ( int i = 1; i < array.Length; i++)
    {
        if (array[i] > maxDigit) maxDigit = array[i];
    }
    return maxDigit;
}
double DifferenceMaxMin(double max, double min)
{
   double result = max - min;
    return result;
}

double[] arr = CreateArrayRndDouble(5, -10, 10);
PrintArray(arr);

double minDigit = MinDigitArray(arr);
double maxDigit = MaxDigitArray(arr);

double result = DifferenceMaxMin(maxDigit,minDigit);
Console.WriteLine($"Разницу между максимальным {maxDigit} и минимальным {minDigit} элементами массива = {result}");
