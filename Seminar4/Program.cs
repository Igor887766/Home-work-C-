/*Урок 4. Функции продолжение
Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
/*
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.Write($"Число {a} в степени {b} равно {result}");
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int numA = ReadInt("Введите число A: ");
int numB = ReadInt("Введите число B: ");
ToDegree(numA, numB);

*/
/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
/*
int num = ReadInt("Введите число: ");
int len = NumberLen(num);
SumNumbers(num, len);



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine($"Сумма цифр числа {num} равна {sum}");
}
*/

/*Задача 29: Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

m = 5 -> [1, 2, 5, 7, 19]

m = 3 -> [6, 1, 33]
*/

/*
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int lenArray = ReadInt("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + ", ");
}
*/

