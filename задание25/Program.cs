//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16


Console.Clear();
Console.Write("Вводим первое числа: ");
int a =int.Parse(Console.ReadLine()!);
Console.Write("Вводим  второе числа: ");
int b =int.Parse(Console.ReadLine()!);
Console.WriteLine(Pow(a, b));
int Pow(int A, int B)
{
    int pow = 1;
    int i = 0;
    while (i < B)
    {
      pow = pow * A;
      i = i + 1;
    }
    return pow;
}


