// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
int n = 3;
int m = 4;

int[,] array = new int[n, m];
GenerateArray(array);
PrintArray(array);
Console.WriteLine();
Console.Write($"Среднеарифметическая каждого столбца равна: ");

void GenerateArray(int[,] array)
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
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
    }
    Console.WriteLine();
}


for (int j = 0; j < array.GetLength(1); j++)
{
    double result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result = (result + array[i, j]);
    }
    result = result / n;
    Console.Write($"{result:F}; ");
}

