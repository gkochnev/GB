// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] array = GetArray(3, 4, -9, 10);
PrintArray(array);
Console.WriteLine();
PrintArray(BubbleSort(array));

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

int[,] BubbleSort(int[,] myArray)
{
   for (int i = 0; i < myArray.GetLength(0); i++)
            {
                for (int k = 0; k < myArray.GetLength(1); k++)
                {
                    for (int j = 0; j < myArray.GetLength(1) - 1; j++)
                    {
                        if (myArray[i, j] < myArray[i, j + 1])
                        {
                            int z = myArray[i, j];
                            myArray[i, j] = myArray[i, j+1];
                            myArray[i, j + 1] = z;
                        }
                    }
                }
            }
            return myArray;
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