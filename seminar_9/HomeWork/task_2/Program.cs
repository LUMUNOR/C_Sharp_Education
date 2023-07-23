//Задача 2:
//Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
//Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.

 void FillPrintArray(int[] array)
  {
   for (int i = 0; i < array.Length; i++)
   {
    array[i] = new Random().Next(1,10);
    Console.Write(array[i]+" ");
   }
   Console.WriteLine();
  }

double SpecConverter(int[]array)
{
    double number = 0;

    for (int i = 0; i < array.Length; i++)
        {
            number += array[i]*Math.Pow(10,(array.Length-i-1));
        }
    
    return number+1;
}
int[] array = new int[5];
FillPrintArray(array);
Console.WriteLine(SpecConverter(array));