// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int [,] matrix = new int[5,5];

void FillArray(int [,] matr) // заполнение матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
            
        }
    }
}

FillArray(matrix);

void PrintArray(int [,] matr) // печать матрицы
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
        Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

PrintArray(matrix);
Console.WriteLine();

void SearchRowsSumm(int [,] matr) //сумма элементов в строке и поиск минимальной суммы
{   
    int rows = 0;
    int min=int.MaxValue;
    for (int i = 0; i < matr.GetLength(0); i++)  
    {   
        int sum = 0;
        
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum+= matr[i,j];
            
        }
        Console.WriteLine($"Строка {i+1}  -- sum ={sum}");
        if (min>sum)
        {
            min=sum;
            rows = i+1;
        }
    }
    Console.WriteLine($"Номер строки: {rows} с наименьшей суммой: {min}");
}

SearchRowsSumm(matrix);