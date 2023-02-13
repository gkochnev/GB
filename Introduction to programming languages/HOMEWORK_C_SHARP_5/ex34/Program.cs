// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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
int[] MyArray = CreateRandomArray(MyArraySize, 100, 999);
Console.WriteLine($"[{string.Join(", ", MyArray)}]");
int count = 0;
for (int i = 0; i < MyArraySize; i++)
{
    if (MyArray[i] % 2 == 0)
    {
        count += 1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");