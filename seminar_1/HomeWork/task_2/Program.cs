﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a>b)
{
    Console.Write($"{a} > {b}");
}
if (b>a)
{
    Console.Write($"{b} > {a}");
}
if (a==b)
{
   Console.Write($"{b} = {a}");
}