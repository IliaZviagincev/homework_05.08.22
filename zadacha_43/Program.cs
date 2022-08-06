// Задача 43:
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// x = (b2 - b1) / (k1 - k2)
// y = k1 * x + b1
double[] GetXY(double b1, double k1, double b2, double k2)
{
    double[] arrXY = new double[2];
    arrXY[0] = (b2 - b1) / (k1 - k2);
    arrXY[1] = k1 * arrXY[0] + b1;
    return arrXY;
}

Console.Write("Введите b1 : ");
double b1 = double.Parse(Console.ReadLine());
Console.Write("Введите k1 : ");
double k1 = double.Parse(Console.ReadLine());
Console.Write("Введите b2 : ");
double b2 = double.Parse(Console.ReadLine());
Console.Write("Введите k2 : ");
double k2 = double.Parse(Console.ReadLine());
Console.Write("(" + String.Join(';', GetXY(b1, k1, b2, k2)) + ")");
