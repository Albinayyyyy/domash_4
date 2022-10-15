//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

void Sum(int n)
{
    int sum = 0;
    while (n > 0)
    {
        sum = sum + (n % 10);
        n = n / 10;
    } 
    return sum;
} 
Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
Console.Write($"Сумма цифр числа {N} равна {(N)}.");