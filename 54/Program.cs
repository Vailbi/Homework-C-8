// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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


void SortMatrix(int [,] matr) // сортировка строк по убыванию
{
int temp = 0;
int step = 0;
while (step<=matr.GetLength(1))
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1)-1; j++) 
        {
            if (matr[i,j]<matr[i,j+1] )
            {
                temp = matr[i,j];
                matr[i,j] = matr[i,j+1];
                matr[i,j+1] = temp;
            }
        }
    }
step++;   
}
    PrintArray(matr);
}

Console.WriteLine();
Console.WriteLine("Отсартированная матрица");
SortMatrix(matrix);

Console.WriteLine();