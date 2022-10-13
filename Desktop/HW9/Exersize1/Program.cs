// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Write a number N: ");
int n = int.Parse(Console.ReadLine()!);

string Recurs (int n, int minValue)
{
    if(minValue == n)
    {
        return n.ToString();
    }
    return (n + " " + Recurs(n-1, minValue));
}
Console.WriteLine(Recurs(n, 1));