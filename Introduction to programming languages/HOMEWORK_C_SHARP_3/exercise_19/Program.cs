// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите целое пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());

int returnDigit (int num, int n)  // num - число, n - номер цифры числа с конца
{
// return Convert.ToInt32(num % Math.Pow(10, n) / Math.Pow(10, n-1));  не корректно работает
int a = Convert.ToInt32(num % Math.Pow(10, n));
int b = Convert.ToInt32(Math.Pow(10, n-1));
return Convert.ToInt32(a / b);
}
//  ;

if (returnDigit(number, 5) == returnDigit(number, 1) & returnDigit(number, 4) == returnDigit(number, 2))
{
    System.Console.Write("да");
}
else
{
    System.Console.Write("нет"); 
}