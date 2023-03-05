// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int n = 3;
int m = 3;
int[,] array = new int[n, m];
GenerateArray(array);
PrintArray(array);
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

int InputUser(string message) 
{ 
    System.Console.Write($"{message}  => "); 
    return Convert.ToInt32(Console.ReadLine()); 
} 
 
Console.WriteLine("введите номер строки");
int k = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int y = Convert.ToInt32(Console.ReadLine());

 if (k > array.GetLength(0) || y > array.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{
    Console.WriteLine($"значение элемента {k} строки и {y} столбца равно {array[k-1,y-1]}");
}



