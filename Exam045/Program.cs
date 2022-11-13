/* Задача 45: Напишите программу, которая 
будет создавать копию заданного массива с помощью
поэлементного копирования. */

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int[] copyArray = CopyArray(array);
//CopyArray(array);
PrintArray(copyArray);

void FillArray(int[] array)
{
    Random random = new Random();
    for (var i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, array.Length);
    }
}

int[] CopyArray(int[] array)
{
    int[] copyArray = new int[array.Length];

    for (var i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
