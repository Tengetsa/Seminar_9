// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Task64()
{
    Console.WriteLine("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    IntervalNaturalNumbers(numberM, numberN);
}

void IntervalNaturalNumbers(int m, int n)
{
    if (m < n)
    {
        while (m <= n)
        {
            Console.Write($"{m} ");
            m += 1;
        }
    }
    else
    {
        while (n <= m)
        {
            Console.Write($"{m} ");
            m -= 1;
        }
    }
}

Task64();