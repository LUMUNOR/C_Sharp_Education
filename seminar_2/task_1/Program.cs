//Напишите программу, которая выводит случайное число 
//из отрезка [10, 99] и показывает наибольшую цифру этого числа

int random = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {random}");

int firstDigit = random / 10;
int secondDigit = random % 10;

if (firstDigit > secondDigit)
{
    Console.WriteLine("Наибольшее число");
}