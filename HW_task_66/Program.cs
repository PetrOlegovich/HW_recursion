// Задача 66: Задайте значения M и N. Напишите программу,
//которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int summ = 0;
int RecSumm(int a, int b)
{
    if (a == b + 1)
    {
        return 0;
    }
    summ = summ + a;
    RecSumm(a + 1, b);
    return summ;
}


Console.WriteLine("Введите число A");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B ");
int numberN = Convert.ToInt32(Console.ReadLine());
int temp = 0;
if (numberM > numberN)
{
    temp = numberM;
    numberM = numberN;
    numberN = temp;
}
Console.WriteLine(RecSumm(numberM, numberN));

