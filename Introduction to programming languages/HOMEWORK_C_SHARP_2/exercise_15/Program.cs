// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели от 1 до 7 включительно");
int number = int.Parse(Console.ReadLine());
if (number == 6 || number == 7)
{
    System.Console.Write("да");
}
else
{
    System.Console.Write("нет"); 
}
