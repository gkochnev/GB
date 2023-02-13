// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число");
int number = Convert.ToInt32(Console.ReadLine());
// int number = int.Parse(Console.ReadLine());
if (number < 100)
{
    System.Console.Write("третьей цифры нет");
}
else
{
    string strNumber = Convert.ToString(number);
    System.Console.Write(strNumber[2]); 
}