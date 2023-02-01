/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, 4
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

int InpuntValues(string text)
{
    System.Console.WriteLine(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void FindXY(double b1, double k1, double b2, double k2)
{
    double X = Math.Round((b2 - b1) / (k1 - k2), 2); //k1*x+b1 = k2*x+b2 -> 5x+2 = 9x+4 -> -4x = 2 -> x = -0,5
    double Y = Math.Round((k1 * X) + b1, 2); // или double Y = k2 * x + b2;
    System.Console.WriteLine($"Точка пересечения двух прямых находится на координатах: [{X}, {Y}]");
}

double b1 = InpuntValues("Введите значение b1: ");
double k1 = InpuntValues("Введите значение k1: ");
double b2 = InpuntValues("Введите значение b2: ");
double k2 = InpuntValues("Введите значение k2: ");

FindXY(b1, k1, b2, k2);