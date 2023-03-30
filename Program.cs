// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
System.Console.WriteLine("Введити значение B1: ");
double B1 = Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine("Введити значение K1: ");
double K1 = Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine("Введити значение B2: ");
double B2 = Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine("Введити значение K2: ");
double K2 = Convert.ToDouble(Console.ReadLine()!);
System.Console.WriteLine($"Координаты: {B1}; {K1}; {B2}; {K2}");

double x = PointX(B1, B2, K1, K2);
double y = PointY(K1, x, B1);
System.Console.WriteLine($"Пересечение: ({x} ; {y})");

//==========метод=============

double PointX(double b1, double b2, double k1, double k2)
{
    var x = -(b1 - b2) / (k1 - k2);
    x = Math.Round(x, 3);
    return x;
}

double PointY(double k1, double x, double b1)
{
    var y = k1 * x + b1;
    y = Math.Round(y, 3);
    return y;
}