/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
 Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29*/

Console.WriteLine("введите первое неотрицательное число");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("введите второе неотрицательное число");
int n = int.Parse(Console.ReadLine());


Console.WriteLine($"результат функции Фккермана от чисел {m} и {n} = " + Akerrman(n, m));



int Akerrman(int n, int m)



{
    if (n == 0) return m + 1;

    if (n != 0 && m == 0) return Akerrman(n - 1, 1);

    if (n > 0 && m > 0) return Akerrman(n - 1, Akerrman(n, m - 1));

    return Akerrman(n, m);
}