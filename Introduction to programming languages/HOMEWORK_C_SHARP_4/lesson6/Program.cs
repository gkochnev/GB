// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]
// int N = 9;
// int[] array = GetArray(N);
// Console.WriteLine($" [ {String.Join(", ", array)} ] ");

// int[] GetArray(int size)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(0, 999);
//     }

//     return result;    
// }
// int[] reverce_array = new int[N];
// for (int i = 0; i < N; i++)
//     {
//         reverce_array[i] = array[N-1-i];
//     }
// Console.WriteLine($" [ {String.Join(", ", reverce_array)} ] ");


// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5-> 01123
// Если N= 3-> 011
// Если N= 7->0112358

// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];
// array[0] = 0;
// array[1] = 1;
// if (N == 1) {Console.WriteLine(array[0]);}
// else if (N == 2) {Console.WriteLine($" [ {String.Join(", ", array)} ] ");}
// else
//     {
//         for (int i = 2; i < N; i++)
//         {
//             array[i] = array[i-2] + array[i-1];
//         }
//     Console.WriteLine($" [ {String.Join(", ", array)} ] ");
//     }


// Задача 42: На ишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int N = Convert.ToInt32(Console.ReadLine());
string binar = "";
while (N > 0)
{
    string temp = (N % 2).ToString();
    binar += temp;
    N = N / 2;
}
string Reverse( string s )
{
char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}
Console.WriteLine(Reverse(binar));
