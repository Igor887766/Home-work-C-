/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
нешел способ решения задачи, как сразу и задумывал*/
/*
int number = ReadInt("Введите число: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));


int ReadInt(string message)
{
    Console.Write(message);
    
    return Convert.ToInt32(Console.ReadLine());
   
}

int MakeArray(int a, int b)
{
int res = 0;
    if (b < 3)
    {
        Console.Write("Третьей цифры нет ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        res = (a / c) % 10;
    }
Console.Write("Третьея цифра ");
return res;

}
*/

/* Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
*/
/*Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();
int b = num.Length;

if (b == 5)
{
    if (num[0] == num[4] && num[1] == num[3])
    {
        Console.WriteLine($"Число {num} - Палиндром");
    }
    else
    {
        Console.WriteLine($"Число {num} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: число {num} - не является пятизначным");
}*/

/*Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

/*
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int x1 = ReadInt("Введите координату X первой точки: ");
int y1 = ReadInt("Введите координату Y первой точки: ");
int z1 = ReadInt("Введите координату Z первой точки: ");
int x2 = ReadInt("Введите координату X второй точки: ");
int y2 = ReadInt("Введите координату Y второй точки: ");
int z2 = ReadInt("Введите координату Z второй точки: ");

int A = x2 - x1;
int B = y2 - y1;
int C = z1 - z2;

double length = Math.Sqrt(A * A + B * B + C * C);
Console.WriteLine($"Растояние между точками составляет {length}");
*/


/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
/*
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int num = ReadInt("Введите число N: ");

 Console.WriteLine($"Таблица кубов чисел от 1 до {num} ");

for (int i = 1; i <= num; i++)
{ 
   
    Console.WriteLine($"Число {i} в кубе составляет {i*i*i} ");
}
*/



