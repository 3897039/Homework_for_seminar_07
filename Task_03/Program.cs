// Задача 3. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] GenerateArray(int row, int col) 
{ 
    int[,] array = new int[row, col]; // Создаем 2-мерный массив 
    Random random = new Random(); 
    for (int i = 0; i < array.GetLength(0); i++) 
    { 
        for (int j = 0; j < array.GetLength(1); j++) 
        { 
            array[i, j] = random.Next(2, 10); 
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
 

 double Average1(int[0, 0] array) 
{ 
    double result = 0; 
    foreach (var item in array) 
    { 
        result += item; 
    } 
    return result / array.Length; 
} 

double Average2(int[1, 0] array) 
{ 
    double result = 0; 
    foreach (var item in array) 
    { 
        result += item; 
    } 
    return result / array.Length; 
} 

double Average3(int[2, 0] array) 
{ 
    double result = 0; 
    foreach (var item in array) 
    { 
        result += item; 
    } 
    return result / array.Length; 
} 

double Average4(int[3, 0] array) 
{ 
    double result = 0; 
    foreach (var item in array) 
    { 
        result += item; 
    } 
    return result / array.Length; 
} 

double[,] matrix = GenerateArray(3, 4); 
PrintArray(matrix); 

Console.WriteLine($"Среднее арифметическое каждого столбца: {Average1(matrix)}:F, {Average2(matrix)}:F, {Average3(matrix)}:F, {Average4(matrix)}:F");


