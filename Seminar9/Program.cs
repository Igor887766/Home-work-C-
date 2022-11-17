/*Урок 9. Как не нужно писать код. Часть 3
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
/*
void PrintNumber(int n, int count)
{
  if (count > n) return;
  PrintNumber(n, count + 1);
  Console.Write(count + ", ");
}

Console.Clear();
int n = InputNumbers("Введите натуральное число: ");
int count = 2;
Console.WriteLine();
Console.Write("[ ");
PrintNumber(n, count);
Console.Write(1);
Console.Write(" ]");

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
   return output;
}
*/

/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
/*
void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов = {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

Console.Clear();
int m = InputNumbers("Введите значение m: ");
int n = InputNumbers("Введите значение n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/
/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/
/*
Console.Clear();
int m = InputNumbers("Введите неотрицательное число m: ");
int n = InputNumbers("Введите неотрицательное число n: ");

int functionAkkerman = Ack(m, n);

Console.Write($"Функция Аккермана = {functionAkkerman} ");

int Ack(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0) return Ack(m - 1, 1);
  else return Ack(m - 1, Ack(m, n - 1));
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/