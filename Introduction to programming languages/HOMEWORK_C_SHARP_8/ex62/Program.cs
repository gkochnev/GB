// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите размер массива (строки = столбцы): ");
int size = int.Parse(Console.ReadLine());
PrintArray(FillSpiralArray(size));

string[,] FillSpiralArray(int arraySize)
{
    string[,] spiralArray = new string[arraySize, arraySize];
    int i = 0;
    int j = 0;
    int counter = 1;

    while (counter <= spiralArray.GetLength(0) * spiralArray.GetLength(1))
    {
        if (counter.ToString().Length < 2)
        {
            spiralArray[i, j] = $"0{counter.ToString()}";
        }
        else
        {
            spiralArray[i, j] = counter.ToString();
        }
        counter++;
        if (i <= j + 1 && i + j < spiralArray.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralArray.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralArray.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralArray;
}

void PrintArray(string[,] inArray)
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



