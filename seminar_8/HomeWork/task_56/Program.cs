//Задача 56: Задайте прямоугольный двумерный массив. 
  //Напишите программу, которая будет находить строку 
  //с наименьшей суммой элементов.Программа считает 
  //сумму элементов в каждой строке и выдаёт номер строки
  //с наименьшей суммой элементов: 1 строка
  
  void Fill2DArray(int[,] array)
  {
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
     array[i, j] = new Random().Next(0, 2);
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
  
  int IndexMinString(int[,]array)
  {
   int minSum =0, minIndex = 0;
  
   for (int i = 0; i < array.GetLength(0); i++)
   {
    int sum=0;
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
     sum +=array[i, j];
    }
    
    if (i==0)
    {
     minIndex = i;
     minSum = sum;
    }
    
    if (sum < minSum)
    {
     minIndex = i;
     minSum = sum;
    }
  
   }
   
   return minIndex+1;
   
  }
  
  int[,] matrix = new int[10,7];
  Fill2DArray(matrix);
  Print2DArray(matrix);
  Console.WriteLine("Строка " + IndexMinString(matrix) + " имеет минимальную сумму всех элементов");