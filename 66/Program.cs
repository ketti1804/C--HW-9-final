/*Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/


using System;
using static System.Console;

Write("Введите m: ");
int m = Convert.ToInt32(ReadLine());
Write("Введите n: ");
int n = Convert.ToInt32(ReadLine());
if (m > n) Write("Сумма элементов от n до m = ");
else Write("Сумма элементов от n до m = ");
Write(SumElements(m, n));

int SumElements(int m, int n)
{
    if (m > n)
        return SumElements(m - 1, n) + m;
    else if (m < n) return SumElements(n - 1, m) + n;
    else return m;
}
