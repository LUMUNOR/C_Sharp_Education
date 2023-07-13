// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Метод запроса числа
double  Request (string massage)
{
    Console.Write(massage);
    double  result = double .Parse(Console.ReadLine());
    return result;
}

double  b1 = Request("Введите коэффециент b1 = ");
double  k1 = Request("Введите коэффециент k1 = ");
double  b2 = Request("Введите коэффециент b2 = ");
double  k2 = Request("Введите коэффециент k2 = ");

double x = (b2-b1)/(k1-k2);
double y = (k1*x)+b1;

Console.Write($"Координата пересечния двух примых ({x}, {y})");