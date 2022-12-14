//Задача 64: Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


void Recurs(int m, int n)
{
    if (n == m+1)
    {
        return;
    }
        Recurs(m, n + 1);
        Console.Write($"{n} ");
}


Console.WriteLine("Введите значение m :");
int numberOne = Math.Abs(Convert.ToInt32(Console.ReadLine()));
int numberTwo = 1;

Recurs(numberOne, numberTwo);

