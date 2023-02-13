// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3 (в условии задачи приведен неверный ответ. чисел больше ноля 4)

// через цикл на вводе данных, без сохранения введенных данных

// int N = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите количество чисел, которые собираетесь ввести:");
// int count = 0;

// for (int i = 0; i < N; i++)
// {
//     Console.WriteLine("Введите число и нажмите Enter:");
//     int number = Convert.ToInt32(Console.ReadLine());
//     if (number > 0)
//     {
//         count += 1;
//     }
// }

// Console.WriteLine($"Из введенных чисел {count} больше ноля");

// через сохранение данных в массив и последующей обработкой функцией через цикл

// Console.WriteLine("Введите количество чисел, которые собираетесь ввести:");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[N];

// for (int i = 0; i < N; i++)
// {
//     Console.WriteLine("Введите число и нажмите Enter:");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }

// int NumbOfBiggerThenZero(int[] myArray)
// {
//     int count = 0;
//     for (int i = 0; i < N; i++)
//     {
//         if (myArray[i] > 0)
//         {
//             count += 1;
//         }
//     }
//     return count;
// }
    
// Console.WriteLine($"Из введенных чисел {NumbOfBiggerThenZero(array)} больше ноля");

Console.Write("Введите числа через пробел: ");
int[] numbers = GetArrayFromString(Console.ReadLine());
Console.WriteLine($"Из введенных чисел {GetCountPositiveElements(numbers)} больше ноля");

int[] GetArrayFromString(string stringArray)
{
    string[] numS = stringArray.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] result = new int[numS.Length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = int.Parse(numS[i]);
    }
    return result;
}

int GetCountPositiveElements(int[] array)
{
    int count = 0;
    foreach (int item in array)
    {
        if (item > 0) count ++;
    }
    return count;
}