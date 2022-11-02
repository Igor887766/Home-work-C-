/*Урок 6. Двумерные массивы и рекурсия

Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 4*/
/*
int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}
int CoutnPositiv(int[] Array)
{
    int sum = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > 0)
        {
            sum = sum + 1;
        }
    }
    return sum;
}
Console.Clear();
Console.Write("Введите числа через пробел: ");
string input = Console.ReadLine()!;
int[] Array = GetArrayFromString(input);
int countNum = CoutnPositiv(Array);
Console.WriteLine($"Количество чисел больше 0 равно: {countNum}");
*/
/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */
/*
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Clear();
        Console.Write("Введите b1: ");
        var b1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k1: ");
        var k1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите b2: ");
        var b2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите k2: ");
        var k2 = Convert.ToDouble(Console.ReadLine());


        var x = -(b1 - b2) / (k1 - k2);
        var y = k1 * x + b1;

        x = Math.Round(x, 3);
        y = Math.Round(y, 3);

        Console.WriteLine($"Прямые пересекутся в точке: ({x};{y})");
    }
}
*/