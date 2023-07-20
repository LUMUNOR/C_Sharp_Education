//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся
//двузначных чисел. Напишите программу, которая будет построчно 
//выводить массив, добавляя индексы каждого элемента.
  
// Метод заполнения 3D массива неповторяющимися двузначными чилами.
  void Fill3DArray(int[,,] array)
  {
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
     for (int k = 0; k < array.GetLength(2); k++)
     {
      int randNumber = new Random().Next(10,100);
      
      while (SheckNumberInArray(array,randNumber,i,j,k))
      {
       randNumber = new Random().Next(10,100);
      }
      
      array[i,j,k] = randNumber;
     }
    }
   }
  }

  // Метод проверяет не весь массив, а только уже инициализированные ячейки.
  bool SheckNumberInArray(int[,,] array,int number,int i,int j,int k)
  {
   for (int l = 0; l <= i; l++)
   { 
    int indexM = array.GetLength(1);
    if (l==i) indexM = j+1;
    for (int m = 0; m < indexM; m++)
    {
     int indexN = array.GetLength(2);
     if (m==j) indexN = k+1;
     for (int n = 0; n < indexN; n++)
     {
      if (number == array[l,m,n]) return true;
     
     }
    }
   }
   
   return false;
  }
  
  // Метод вывода элементов с индексами.
  void Print3DArrayWithInd(int[,,] array)
  {
   for (int i = 0; i < array.GetLength(0); i++)
   {
    for (int j = 0; j < array.GetLength(1); j++)
    {
     for (int k = 0; k < array.GetLength(2); k++)
     {
      Console.Write($"{array[i,j,k]} [{i}, {j}, {k}]  ");
     }
        Console.WriteLine();
    }
   }
  }
  
  int[,,] array3D = new int[3,3,3];// Количество элементов не должно
  //превышать 89(это количество положительных двузначных чисел)
  Fill3DArray(array3D);
  Print3DArrayWithInd(array3D);