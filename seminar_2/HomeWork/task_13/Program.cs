//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

if (Math.Abs(number) > 99)
{
    while (Math.Abs(number) >= 1000)
    {
        number = number/10;
    }

    Console.WriteLine($"Третья цифра числа {Math.Abs(number%10)}"); 
}
else Console.WriteLine("Третьей цифры нет");
