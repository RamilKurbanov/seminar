// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

using MyLyb;


int[,] Matrix(int[,] A, int[,] B)
{
    int rowsA = A.GetLength(0);
    int colsA = A.GetLongLength(1);
     int rowsB = B.GetLength(0);
    int colsB = B.GetLongLength(1);
    if(rowsA != rowsB)
    {
        throw new ArgumentException(" число в строках матрицы не равно \n" + "произведение выполнить невозможно \n\n");
    }
    int rowC = rowsA;
    
    int colsC = (colsA > colsB) ? colsB : colsA;
    bool flag = (colsA > colsB);

    int[,] C = new int[rowC, colsC];
    for(int i = 0; i < rowC; i++)
    {
        for ( int j = 0; j < colsC; j++)
        {
            C[i,j] = 0;
            for (int k = 0; k < rowsB; k++)
            {
                C[i, j] += (flag) ? (A[i,k] * B[k,j]) : A[k,j] * B[i,k];
            }
        }
    }
return C;

}


int[,] matrixA = Function.GetArray(2, 2, 1, 9);
int[,] matrixB = Function.GetArray(2, 2, 1, 9);

Function.GetArray(matrixA);
Console.WriteLine(" - - - - - - - -");
Function.GetArray(matrixB);
Console.WriteLine(" - - - - - - - -");

int[,] matrixC = Matrix(matrixA, matrixB);
Function.PrintArray(matrixC);
