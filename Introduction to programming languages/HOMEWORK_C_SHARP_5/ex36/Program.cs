// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int N, int start, int end)
{
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++)
    {
        RandomArray[i] = new Random().Next(start, end + 1);
    }
    return RandomArray;
}

Console.WriteLine("введите количество случайных чисел в массиве");
int MyArraySize = Convert.ToInt32(Console.ReadLine());
int[] MyArray = CreateRandomArray(MyArraySize, 0, 10);
Console.WriteLine($"[{string.Join(", ", MyArray)}]");
int SumOfOddNumbers = 0;
for (int i = 1; i < MyArraySize; i+=2)
{
    SumOfOddNumbers += MyArray[i];
}
Console.WriteLine($"Сумма элементов с нечетными индексами: {SumOfOddNumbers}");
