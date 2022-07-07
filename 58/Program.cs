// Задача 58: Задайте две матрицы. Напишите программу,
//  которая будет находить произведение двух матриц.

int [,] matrixOne = new int[3,3];
int [,] matrixTwo = new int[3,3];

void FillArray(int [,] matr) // заполнение матрицы случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)  
    {   
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,5);
            
        }
    }
}

FillArray(matrixOne);
FillArray(matrixTwo);

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

PrintArray(matrixOne);
Console.WriteLine();
PrintArray(matrixTwo);
Console.WriteLine();

void ProductOfMatrix(int[,] matr1, int[,] matr2)
{

    int [,] resultMatrix = new int[matr1.GetLength(0),matr1.GetLength(1)];
    for (int i = 0; i < resultMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < resultMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < resultMatrix.GetLength(0); k++)
            {
                resultMatrix[i,j] += matr1[i,k]*matr2[k,j];
            }
        }
    }

    PrintArray(resultMatrix);
}

ProductOfMatrix(matrixOne,matrixTwo);
