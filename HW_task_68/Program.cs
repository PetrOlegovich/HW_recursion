﻿// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

static int Akkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    if (n != 0 && m == 0)
    {
        return Akkerman(n - 1, 1);
    }

    if (n > 0 && m > 0) 
    {
        return Akkerman(n-1,Akkerman(n,m-1));
    }
return Akkerman(m, n);
}
Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число M ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Akkerman(M, N));


