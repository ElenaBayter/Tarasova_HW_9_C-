// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Write a number M: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Write a number N: ");
int n = int.Parse(Console.ReadLine()!);

int SumArray (int m, int n)
{
    if(m == n)
    {
        return m;
    }
    return n + SumArray(m, n-1);   
}
Console.WriteLine(SumArray(m, n));