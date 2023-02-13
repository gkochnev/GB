// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
// Условие задачи не соответствует предлагаемому в примере результату

// Console.Write("Введите номер строки искомого элемента: ");
// int row = int.Parse(Console.ReadLine());

// Console.Write("Введите номер столбца искомого элемента: ");
// int column = int.Parse(Console.ReadLine());

int rows = 7;
int columns = 9;
int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);

// Проверка, есть ли элемент с указанной позицией в массиве. Если есть, возвращает его значение.

// if ((row >= 0 & row <= rows) & (column >= 0 & column <= columns))
// {
//     Console.Write(array[row, column]);
// }
// else
// {
//     Console.Write("Такого элемента в массиве нет.");
// }

// Проверка, есть ли указанное число в массиве. Если есть, возвращает его позицию, если нет "такого числа в массиве нет".

Console.Write("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
CheckElement(number, array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void CheckElement(int Value, int[,] inArray)
{
    int count = 0;
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (Value == inArray[i, j])
            {
                Console.WriteLine($"{i}, {j}");
                count ++;
            }
        }
    }
    if (count == 0)
    {
        Console.WriteLine("такого числа в массиве нет");
    }
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