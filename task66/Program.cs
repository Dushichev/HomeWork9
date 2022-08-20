/*Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

Console.WriteLine("введите первое натуральное число");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе натуральное число");
int n = int.Parse(Console.ReadLine());

Console.WriteLine($"сумма чисел данной последовательности от {m} до {n} = " + ResultSum(m, n));



int ResultSum(int start, int end)
{
    {

        if (end == start)
        {
            return start;

        }
        return start + ResultSum(start + 1, end);


    }
}


