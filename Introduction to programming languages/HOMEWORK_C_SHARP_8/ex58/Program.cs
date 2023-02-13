// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] arrayA = GetArray(2, 3, 0, 5);
PrintArray(arrayA);
Console.WriteLine();
int[,] arrayB = GetArray(3, 2, 0, 5);
PrintArray(arrayB);
Console.WriteLine();
int[,] arrayC = ProductOfArrays(arrayA, arrayB);
PrintArray(arrayC);
Console.WriteLine();

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

int[,] ProductOfArrays(int[,] inArrayA, int[,] inArrayB)
{
    int[,] result = new int[inArrayA.GetLength(0), inArrayB.GetLength(1)];
    for (int i = 0; i < inArrayA.GetLength(0); i++)
    {
        for (int k = 0; k < inArrayB.GetLength(1); k++)
        {
            for (int j = 0; j < inArrayA.GetLength(1); j++)
            {
                result[i, k] += inArrayA[i, j] * inArrayB[j, k];
            }
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

