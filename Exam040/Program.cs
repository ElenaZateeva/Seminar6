// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string[] ReverseArray(string[] array)
{
    string[] reversed = new string[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        reversed[i] = array[array.Length - 1 - i];
    }

    return reversed;
}

///////
string result = ConvertDecToBinary(4); //вызвали метод
Console.WriteLine(result); //вывели на экран
string ConvertDecToBinary(int number) //объявили метод
{
    string tmp = "";
    while (number > 0)
    {
        int remainder = number % 2;
        number /= 2;
        tmp = remainder.ToString() + tmp;
        
    }
    return tmp; //вернули результат

}

Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
double[] arrayFibonacci = Fibonacci(number);
PrintArray(arrayFibonacci);

double[] Fibonacci(int n)
{
    double[] array = new double[n];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

