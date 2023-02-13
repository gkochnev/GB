// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целое положительное число (начало): ");
int start = int.Parse(Console.ReadLine());
Console.Write("Введите целое положительное число (конец): ");
int end = int.Parse(Console.ReadLine());
Console.WriteLine($"M = {start}; N = {end} -> {SunOfNumbers(start, end)}");

int SunOfNumbers(int start, int end)
{
    if (end < start) return 0;
    return end += SunOfNumbers(start, end - 1);
}