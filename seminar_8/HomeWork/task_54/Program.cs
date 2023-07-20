//Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит 
//по убыванию элементы каждой строки двумерного массива.

  void Fill2DArray(int[,] array)
  {
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
     array[i, j] = new Random().Next(-10, 11);
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

  void Order2DArray(int[,] array)
  {
   var box = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < (array.GetLength(1)-1); j++)
    {
     for (int k = 1+j; k < array.GetLength(1); k++)
     {
      if (array[i,k]>array[i,j])
      {
       box=array[i,k];
       array[i,k]=array[i,j];
       array[i,j]=box;
      }
     }
    }
   }
  }

  int[,] matrix = new int[15, 9];
  Fill2DArray(matrix);
  Print2DArray(matrix);
  Console.WriteLine(" Сортируем...");
  Order2DArray(matrix);
  Print2DArray(matrix);