// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Метод ввода координат точек
int[] Request (string massage)
{
    Console.WriteLine(massage);
    int[] dot = new int[3];
    string[] XYZ = {"X: ","Y: ","Z: "};
    for (int i = 0; i < 3; i++)
    {
        Console.Write(XYZ[i],"  ");
        dot[i]= int.Parse(Console.ReadLine());
    }
    Console.WriteLine(" ");
    return dot;
}

// Метод подсчета расстояния между двумя точками в 3-мерном пространстве
double Distance3D (int[]dotA, int[]dotB)
{
    return Math.Sqrt( Math.Pow((dotB[0]-dotA[0]),2) + Math.Pow ((dotB[1]-dotA[1]),2) + Math.Pow ((dotB[2]-dotA[2]),2) );
}
// [[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[[]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]]

Console.WriteLine(" ");

int[] dotA = Request("Введите коордитаты точки A");
int[] dotB = Request("Введите коордитаты точки B");

Console.WriteLine($"Расстояние между точками = {Distance3D(dotA,dotB)}");
Console.WriteLine(" ");