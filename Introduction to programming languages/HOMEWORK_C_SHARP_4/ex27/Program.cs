// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Enter number");
int A = Convert.ToInt32(Console.ReadLine());
int Sum = 0;
while (A > 0)
{
    int LastDigit = A % 10;
    Sum = Sum + LastDigit;
    // A = Convert.ToInt32(A / 10);
    A = A / 10;
}

Console.WriteLine($"Сумма цифр числа равна {Sum}");