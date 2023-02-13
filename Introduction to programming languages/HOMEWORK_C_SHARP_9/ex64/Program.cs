// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите целое положительное число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"N = {number} -> {NumbersFromNTo1(number)}");

string NumbersFromNTo1(int n)
{
    if (n == 1 || n == 0) return "1";
    return $"{n}, " + NumbersFromNTo1(n-1);
}
