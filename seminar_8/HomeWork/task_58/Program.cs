//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
 
 void Fill2DArray(int[,] array)
  {
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
     array[i, j] = new Random().Next(1, 5);
    }
   }
  }

  void Print2DArray(int[,] array)
  {
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
     Console.Write(string.Format("{0,4} ", array[i, j]));
    }
    Console.WriteLine();
   }
  }

int[,] MultiplyMatrix (int[,]matrixA,int[,]matrixB)
{
    int[,] matrixC = new int[matrixA.GetLength(0),matrixB.GetLength(1)];

    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            for (int r = 0; r < matrixA.GetLength(1); r++)
            {
                matrixC[i,j] += matrixA[i,r]*matrixB[r,j];
            }
        }
    }

    return matrixC;  
}

int[,] matrixA = new int[2,3];
int[,] matrixB = new int[matrixA.GetLength(1),4];
Fill2DArray(matrixA);
Print2DArray(matrixA);
Console.WriteLine();
Fill2DArray(matrixB);
Print2DArray(matrixB);
Console.WriteLine();
Print2DArray(MultiplyMatrix(matrixA,matrixB));