// Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите число");
double k1 = double.Parse(Console.ReadLine());
double k2 = double.Parse(Console.ReadLine());
double b1 = double.Parse(Console.ReadLine());
double b2 = double.Parse(Console.ReadLine());
Intersection(k1, k2, b1, b2);

void Intersection(double k1, double k2, double b1, double b2)
{
    double coef = k1 - k2;
    if (coef != 0)
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($"Точка пересечения ({x}; {y})");
    }
    else if(b1==b2 && k1==k2)
        {
        Console.WriteLine("Прямые совпадают");
        }
    else Console.WriteLine("Прямые паралельны");
        
}



