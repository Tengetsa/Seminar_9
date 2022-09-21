// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Task64()
{
    Console.WriteLine("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(IntervalNaturalNumbers(numberM, numberN));
}

int IntervalNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return n;
    }  
    else if (m > n)
    {
        Console.Write($"{IntervalNaturalNumbers(m, n + 1)}, ");
        return n;
    }
    else
        Console.Write($"{IntervalNaturalNumbers(m, n - 1)}, ");
    return n;
}

Task64();