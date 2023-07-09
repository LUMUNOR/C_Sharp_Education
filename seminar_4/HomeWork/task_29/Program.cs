// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// Метод заполнения массива
void FillArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(-10,51);
   }  
}

// Метод вывода массива
void WriteArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
   {
    Console.Write ($"{array[i]} ");
   }  
}

//////////////////////////////////////////////////////////////////////////////////////

int[] array = new int[8];

FillArray (array);
WriteArray (array);