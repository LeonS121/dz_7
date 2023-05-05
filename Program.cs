// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int line = ReadInt("Введите число m: ");
int colums = ReadInt("Введите число n: ");
double[,] numbers = new double[line, colums];
FillArray(numbers);
PrintArray(numbers);


 void FillArray(double[,] array)
 {
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-99, 99) / 10.0;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
    {
        Console.Write(message);
        return Convert.ToInt32(Console.ReadLine());
    }


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int line = ReadInt("Введите число: ");
int colums = ReadInt("Введите число: ");
int[,] numbers = new int[6, 8];
FillArray(numbers);
PrintArray(numbers);

if (line < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[line, colums]);
else Console.WriteLine($"{line}{colums} -> такого числа в массиве нет");

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] randomArr = new int[m,n];

void mas(int m, int n)
    {
    int i,x;
    Random rand = new Random();
        for (i = 0; i < m; i++)
        {
            Console.WriteLine();
            for (x = 0; x < n; x++)
            {
            randomArr[i,x] = rand.Next(1,9);
            Console.Write($"{randomArr[i,x]} ");
            }
        Console.WriteLine();
        }
    }

void average(int m, int n)
    {
    Console.Write("Среднее арифметическое каждого столбца: ");
    int i,x;
    Random rand = new Random();
        for (x = 0; x < n; x++)
        {
            double sum = 0;
            for (i = 0; i < m; i++)
            {
            sum = sum + randomArr[i,x];
            }
        Console.Write($"{sum/(i):F1}; ");
        }
    }
mas(m,n);
average(m,n);