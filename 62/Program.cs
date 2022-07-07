// Задача 62: Заполните спирально массив 4 на 4.

int [,] matrix = new int [4,4];
int num = 1;
int row=0;
int col=0;
void FillImage (int row, int col) // заполнение первой ячейка
{
    matrix[row,col] = num;
    num++;
}
void FillMatrixRight (int row, int col) // движение вправо
{
    matrix[row,col+1] = num;
    num++;
}
void FillMatrixDown (int row, int col) // движение вниз
{
    matrix[row+1,col] = num;
    num++;
}
void FillImgLeft (int row, int col) // движение влево
{
    matrix[row,col-1] = num;
    num++;
}
void FillImgUp (int row, int col) // движение вверх
{
    matrix[row-1,col] = num;
    num++;
}

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
int step = matrix.GetLength(0)*matrix.GetLength(1);

FillImage(row,col);

for (int i = 0; i < step; i++) //цикл для заполнения матрицы
{
    if (col<matrix.GetLength(1)-1 && matrix[row,col+1]==0)
    {
        FillMatrixRight(row,col);
        col++;
    }
    else if (row<matrix.GetLength(0)-1 && matrix[row+1,col]==0)
    {
        FillMatrixDown(row,col);
        row++;
    }
    else if (col>0 && matrix[row,col-1]==0)
    {
        FillImgLeft(row,col);
        col--;
    }
    else while (row>0 && matrix[row-1,col]==0)
    {
        FillImgUp(row,col);
        row--;
    }
}

PrintArray(matrix);