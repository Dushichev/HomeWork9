﻿/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
 в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""

M = 4; N = 8. -> ""4, 6, 7, 8""*/

Console.WriteLine("введите первое натуральное число");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе натуральное число");
int n = int.Parse(Console.ReadLine());

Console.Write($"последовательность чисел от  {m} до  {n} = ");
Resultmultiplication(m, n);

void Resultmultiplication(int start, int end)
{

    {
        if (start > end)
        {
            return;
        }
        Console.Write(" " + start);
        start++;
        Resultmultiplication(start, end);
    }
}
