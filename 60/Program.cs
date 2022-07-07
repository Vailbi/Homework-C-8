// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int [,,] matrix = new int [3,3,3];
int number = 10;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            matrix[i,j,k] = number ++; 
        }
    }
}


void PrintArray(int [,,] matr) 
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                Console.Write($"[{i},{j},{k}] {matr[i,j,k]}  ");
            }
            Console.WriteLine();
        }
    }
}

PrintArray(matrix);