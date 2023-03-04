// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого числа в массиве нет

int[,] GenerateArray(int row, int col) 
{ 
    int[,] array = new int[row, col]; // Создаем 2-мерный массив 
    Random random = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = random.Next(2, 100); 
        } 
    } 
    return array; 
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
 
 (bool isNotFinde, int row, int col) FindePosition(int[,] array) 
{ 
    row = Convert.ToInt32(textBox1.Text);
    col = Convert.ToInt32(textBox2.Text);
    Int32[,] array2 = new Int32[row, col];
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            if (array2[row, col] == array[i, j]) 
            { 
                return (true, i, j); 
            } 
        } 
    } 
    return (false, -1, -1); 
} 

int[,] matrix = GenerateArray(4, 4); 
PrintArray(matrix); 
int k = InputUser("Введите индекс строки"); 
int y = InputUser("Введите индекс столбца"); 
var result = FindePosition(matrix, array2); 
if (result.isNotFinde) Console.WriteLine("Такого элемента нет"); 