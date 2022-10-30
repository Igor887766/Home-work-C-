/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
/*
Console.Write("Введите длину массива: ");

int size = Convert.ToInt32(Console.ReadLine());

int[] num = new int[size];

RandonNumbers(num);

Console.WriteLine("Числа в этом массиве: ");

PrintArray(num);

void RandonNumbers(int[] num)
{
    for(int i = 0; i < size; i++)
    {
        num[i] = new Random().Next(100,1000);
    }
}

int count = 0;

for (int x = 0; x < num.Length; x++)
{
if (num[x] % 2 == 0)
count++;
}
Console.WriteLine($"из {num.Length} чисел массива, {count} четных");


void PrintArray(int[] num)
{
    Console.Write("[ ");

    for(int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.Write("]");

    Console.WriteLine();
}
*/
/*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
/*Console.Write("Введи длину массива: ");

int ElementNum = Convert.ToInt32(Console.ReadLine()); 

int randomNum =  RandomNumbers(ElementNum, 1, 100);

Console.Write($"Сумма элементов, стоящих на нечётных позициях = {randomNum}");

int RandomNumbers(int ElementNum, int min, int max)
  {
  int[] randomNum = new int[ElementNum];

  int sum = 0;

  Console.WriteLine("Получившийся массив: ");

    Console.Write("[");

    for (int i = 0; i <randomNum.Length; i++ )
    {
      randomNum[i] = new Random().Next(min, max);

      Console.Write(randomNum[i] + " ");

      if (i % 2 > 0)
      {
        sum = sum + randomNum[i];
      }
    }
     Console.WriteLine("]");

  return sum;
  }
*/
/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

/*
Console.Write("Введите длину массива: ");

int size = Convert.ToInt32(Console.ReadLine());

double[] number = new double[size];

FillArrayRandomNumbers(number);

Console.WriteLine("Массив: ");

PrintArray(number);

double min = Int32.MaxValue;

double max = Int32.MinValue;

for (int a = 0; a < number.Length; a++)
{
    if (number[a] > max)
        
            max = number[a];
        
    if (number[a] < min)
        
            min = number[a];
        
}

Console.WriteLine($"Всего в массиве {number.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разность между максимальным и минимальным = {max - min}");

void FillArrayRandomNumbers(double[] number)
{
    for(int i = 0; i < number.Length; i++)
        
            number[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        
}
void PrintArray(double[] number)
{
    Console.Write("[ ");
    for(int i = 0; i < number.Length; i++)
        
            Console.Write(number[i] + " ");
        
    Console.Write("]");
    Console.WriteLine();
}
*/