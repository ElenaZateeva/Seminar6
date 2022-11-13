// Задача 40 
// Программа на входе получает 3 числа и проверяет: могут ли данные значения 
// являться сторонами треугольника

Console.WriteLine("Введите 3 числа:");
int a1 = Convert.ToInt32(Console.ReadLine());
int b1 = Convert.ToInt32(Console.ReadLine());
int c1 = Convert.ToInt32(Console.ReadLine());
bool temp = ItsTriangle(a1, b1, c1);
Console.WriteLine($"{temp}");

bool ItsTriangle(int a, int b, int c)
{
    return (a + b > c & b + c > a & a + c > b);
}