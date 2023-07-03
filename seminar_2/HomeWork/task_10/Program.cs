// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число ");
int number = int.Parse(Console.ReadLine());

if (((number > 99) && (number < 1000))||((number > -1000) && (number < -99)))
{
   Console.WriteLine($"Вторая цифра числа {(number/10)%10}"); 
}
else Console.WriteLine("Вы ввели не трехзначное число");