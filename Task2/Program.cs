/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/

double GetNumber(string msg)
{
    Console.Write(msg);
    double userNumber = Convert.ToDouble(Console.ReadLine());
    return userNumber;
}

double k1 = GetNumber("Введите число k1: ");
double b1 = GetNumber("Введите число b1: ");
double k2 = GetNumber("Введите число k2: ");
double b2 = GetNumber("Введите число b2: ");

if (k1 == k2)
{
    Console.WriteLine("Прямые не пересекаются");
}
else
{
    var x = (b2 - b1) / (k1 - k2);
    var y = k1 * x + b1;
    x = Math.Round(x, 2);
    y = Math.Round(y, 2);
    Console.WriteLine($"Прямые пересекаются в точке ({x}; {y}).");
}
