//Задача 1.
//Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
//Ваша задача вывести на экран максимальное количество следующих друг за другом 1.
  
  void FillPrintArray(int[] array)
  {
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(0,2);
    Console.Write(array[i]);
   }
   Console.WriteLine();
  }

  int MaxSub(int[] array)
  {
   int maxPovtor = 0;
   int povtor = 1;
   for (int i = 0; i < (array.Length-1); i++)
   {
    if ((array[i]==1)&&(array[i+1]==1))
    {
     povtor++;
     if (maxPovtor < povtor) maxPovtor = povtor;
    }
    else povtor = 1;
   }
   return maxPovtor;
  }

  int[]array = new int[10];
  FillPrintArray(array);
  Console.Write($"Максимальная непрерывная последовательность '1' {MaxSub(array)} раз(a)");