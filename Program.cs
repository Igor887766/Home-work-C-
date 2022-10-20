// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write ("Введите первое число: ");
int n1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число: ");
int n2 = Convert.ToInt32 (Console.ReadLine());
if (n1>n2)
{
    Console.Write($"{n1} большее число, {n2} меньшее число");
    }
else
{
    Console.Write($"{n2} большее число, {n1} меньшее число");
    }
