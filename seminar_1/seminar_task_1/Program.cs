// Напишите программу, которая на вход принимает число (число > 10)
// и выдает квадрат этого числа.

// Исходное число
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number <= 10)
{
    Console.WriteLine("Ваше число не соответствует условию");
}
else
{
    //Резальтат: квадрат исходного числа
    int result = number * number;

    //Вывод результата
    Console.WriteLine($"Квадрат вашего числа = {result}");
}

Console.WriteLine("Конец программы");