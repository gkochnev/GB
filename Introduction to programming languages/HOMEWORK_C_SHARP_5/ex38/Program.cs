// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateRandomDoubleArray(int N, int start, int end)
{
    double[] RandomDoubleArray = new double[N];
    for (int i = 0; i < N; i++)
    {
        RandomDoubleArray[i] = new Random().Next(start, end + 1) + Math.Round(new Random().NextDouble(), 2);
    }
    return RandomDoubleArray;
}

Console.WriteLine("введите количество случайных чисел в массиве");
int MyArraySize = Convert.ToInt32(Console.ReadLine());
double[] MyArray = CreateRandomDoubleArray(MyArraySize, -10, 10);
Console.WriteLine($"[{string.Join(", ", MyArray)}]");

Console.WriteLine($"Минимальное число в массиве: {MyArray.Min()}");
Console.WriteLine($"Максимальное число в массиве: {MyArray.Max()}");
Console.WriteLine($"Разница между минимальным и максимальным элементами массива: {MyArray.Max() - MyArray.Min()}");