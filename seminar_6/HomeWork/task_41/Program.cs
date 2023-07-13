// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Метод запроса числа
int Request (string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int m = Request("Сколько чиесел хотите ввести? - ");

Console.WriteLine("Приступим кo вводу!");

int counter = 0;
int number = 0;

for (int i=0; i<m; i++)
{
    number = int.Parse(Console.ReadLine());
    if (number > 0) counter++;
}

Console.WriteLine($"Вы ввели {counter} положительных чисел(a).");