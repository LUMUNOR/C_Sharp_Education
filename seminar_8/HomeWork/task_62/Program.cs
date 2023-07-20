//Задача 62. Напишите программу, которая заполнит 
  //спирально массив.

// Метод запроса числа целого числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}
// Метод заполнения по спирали
  void FillSpiral(int[,] array)
  {
   int count = 1;
   int z = 0;
   int iL = array.GetLength(0) - 1;
   int jL = array.GetLength(1) - 1;

   while ((z<(array.GetLength(0)-1))&&(z<(array.GetLength(1)-1)))
   {
    for (int j = z; j <= jL-z; j++)
    {
     if (array[z, j] != 0) break;
     array[z, j] = count;
     count++;
    }

    for (int i = z+1; i <= iL-z; i++)
    {
     if (array[i, jL-z] != 0) break;
     array[i, jL-z] = count;
     count++;
    }

    for (int j = jL - (z+1); j >= z; j--)
    {
     if (array[iL-z, j] != 0) break;
     array[iL-z, j] = count;
     count++;
    }

    for (int i = iL - (z+1); i >= z + 1; i--)
    {
     if (array[i, z] != 0) break;
     array[i, z] = count;
     count++;
    }
    z++;
   }

  }

//Метод вывода на экран двумерного массива
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
  int m = Request("Введите число сток: ");
  int n = Request("Введите число столбцов: ");
  int [,] array = new int[m,n];
  FillSpiral(array);
  Print2DArray(array);