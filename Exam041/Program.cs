/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.WriteLine("Введите количество элементов массива:");
bool isParsedM = int.TryParse(Console.ReadLine(), out int m);
if (!isParsedM)
{
    Console.WriteLine("Ошибка ввода числа!");
    return;
}

int[] numbers = new int[m];
FillArray(numbers,-99,99);
PrintArray(numbers);
Console.WriteLine($"Количество положительных чисел в массиве = {CountPositiveNumbers(numbers)}");

void FillArray(int[] array, int min, int max)
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(min, max);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
        Console.WriteLine();
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i]> 0)
            count++;
    }
    return count;
}


