//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите номер дня недели ");
int number = int.Parse(Console.ReadLine());

if ((number >= 1) && (number <= 7))
{
    if ((number==6)||(number==7))
    {
        Console.WriteLine("Да, это выходной!");
    }
    else Console.WriteLine("Иди работай!");
}
else Console.WriteLine("Читать умеешь?!");