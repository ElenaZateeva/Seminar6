// Перевод 10-тичных чисел в двоичные
// Используем строку для сбора результата!!!

Console.WriteLine("Введите любое число");
int number = Convert.ToInt32(Console.ReadLine());

string result = ConvertDecToBinary(number); //вызвали метод
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
