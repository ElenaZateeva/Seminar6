/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
 заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
 значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
Console.WriteLine("Введите данные линейных уравнений y1=k1*+b1 и y2-k2*x+b2:k1");
Console.WriteLine("Последовательно: k1, b1, k2, b2");

bool isParsedK1 = double.TryParse(Console.ReadLine(), out double k1);
bool isParsedB1 = double.TryParse(Console.ReadLine(), out double b1);
bool isParsedK2 = double.TryParse(Console.ReadLine(), out double k2);
bool isParsedB2 = double.TryParse(Console.ReadLine(), out double b2);
if (!isParsedK1 || !isParsedK2 || !isParsedB1 || !isParsedB2)
{
    Console.WriteLine("Ошибка ввода данных!");
    return;
}
(double, double) line=LineIntersectionPoint(k1, k2, b1, b2);
Console.WriteLine();
Console.WriteLine($"Точка пересечения: ({line.Item1}; {line.Item2})");

(double, double) LineIntersectionPoint(double k1, double k2, double b1, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    return (x, y);
}