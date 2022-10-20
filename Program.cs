// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/*
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
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write ("Введите первое число: ");
int n1 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите второе число: ");
int n2 = Convert.ToInt32 (Console.ReadLine());
Console.Write ("Введите третье число: ");
int n3 = Convert.ToInt32 (Console.ReadLine());
if (n1 > n2)
{
    if (n1 > n3)
    {
        Console.WriteLine("Максимальное число: " + n1);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + n3);
    }
}

else if (n2 > n3)
{
    Console.WriteLine("Максимальное число: " + n2);
}
else
{
    Console.WriteLine("Максимальное число: " + n3);
}

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
