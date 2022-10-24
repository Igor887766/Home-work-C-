/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/

/*int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
else
{
    Console.WriteLine("второе число = " + InCenter(number));
}
*/

/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 53


78 -> третьей цифры нет

32679 -> 6
*/

int ThirdNumber (int num)
{
 int result;
    int num1;
     while (num > 1000)
    {
    num1 = num / 10;
    result = num % 10;
    }
  return result;
}

Console.WriteLine("введите число: ");

int num11 = Convert.ToInt32(Console.ReadLine());

if (num11 < 100)
{
         Console.WriteLine ("третьей цифры нет");
}
else
{
       int res = ThirdNumber (num11);

        Console.Write("третья цифра = " (res));
}


/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/
/*
Console.Write("Введите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (0 < n && n < 8)
    if (n==6 | n==7)
    Console.Write("да");
    else 
    Console.Write("нет");
 else 
    Console.Write("нет такого дня недели");
*/