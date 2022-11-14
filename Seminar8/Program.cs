/*Урок 8. Как не нужно писать код. Часть 2
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
/*
Console.Clear();
Console.Write("Введите количество строк: ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[linesVol, columnsVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine();
Console.WriteLine("Массив до изменения:");
PrintArray(numbers);
            
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < numbers.GetLength(1) - 1; z++)
            {
                if (numbers[i, z] < numbers[i, z + 1]) 
                {
                     int temp = 0;
                    temp = numbers[i, z];
                    numbers[i, z] = numbers[i, z + 1];
                    numbers[i, z + 1] = temp;
                }
            }
        }
    }
Console.WriteLine();
Console.WriteLine("Массив с упорядоченными значениями по убыванию:");
PrintArray(numbers);
            
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
        for (int j = 0; j < array.GetLength(1); j++)
            {
            array[i, j] = new Random().Next(0, 10);
            }
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
             for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write(array[i, j] + " ");
            }
        Console.Write("]");
        Console.WriteLine("");
    }
}
        */

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
/*
Console.Clear();
Console.Write("Введите размер квадратного массива: ");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[massVol, massVol];
FillArrayRandomNumbers(numbers);
Console.WriteLine("");
PrintArray(numbers);
int minsum = Int32.MaxValue;
int indexLine = 0;
            
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        int sum = 0;
            for (int j = 0; j < numbers.GetLength(1); j++)
            
                sum = sum + numbers[i, j];
            
            if (sum < minsum)
            {
                minsum = sum;
                indexLine++;
            }
    }
 Console.WriteLine("");           
 Console.WriteLine("Строка с наименьшей суммой элементов под номером: " + (indexLine) + ". Сумма элементов в строке равна: " + (minsum));
            
void FillArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}
            
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
             Console.Write(array[i, j] + " ");
    }
    Console.Write("]");
    Console.WriteLine("");
    }
}
*/
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
/*
Console.Clear();
int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] array = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];
            
FillArrayRandom(array);
Console.WriteLine("Первая матрица:");
PrintArray2D(array);
            
Console.WriteLine();
            
FillArrayRandom(secondArray);
Console.WriteLine("Вторая матрица:");
PrintArray2D(secondArray);
            
Console.WriteLine();
            
    if (array.GetLength(0) != secondArray.GetLength(1))
    {
        Console.WriteLine(" Нельзя перемножить ");
    return;
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < secondArray.GetLength(1); j++)
        {
            resultArray[i, j] = 0;
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    resultArray[i, j] += array[i, k] * secondArray[k, j];
                }
        }
    }
Console.WriteLine("Матрица произведение первой и второй:");
PrintArray2D(resultArray);
       
    int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }
            
void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}
    
void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i, j]} ");
            }
            Console.Write("]");
            Console.WriteLine();
            }
    }  
Console.WriteLine();
*/
  
/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет 
построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

/*
Console.Clear();
int x = InputNumbers("Введите длину массива: ");
int y = InputNumbers("Введите ширину массива: ");
int z = InputNumbers("Введите высоту массива: ");
Console.WriteLine($"");

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
WriteArray(array3D);

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void WriteArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
              Console.Write( $"{array3D[i,j,k]} ({i},{j},{k}); ");
      }
      Console.WriteLine();
    }
  }
}
Console.WriteLine($"");

void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
*/
/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

/*
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}       

Console.Clear();
Console.Write("Введите длину спирального массива: ");
 int len = int.Parse(Console.ReadLine()!);
int[,] table = new int[len, len];
FillArraySpiral(table, len);
Console.WriteLine();
PrintArray(table);
*/