// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void Task66()
{
    Console.WriteLine("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine($"{TheSumOfNaturalElements(numberM, numberN)}");
}

int TheSumOfNaturalElements(int m, int n)
{
    if (m == n)
    {
        return n;
    }
    else if (m > n)
    {
        return m + TheSumOfNaturalElements(m - 1, n);
    }
    else
    {
        return m + TheSumOfNaturalElements(m + 1, n);
    }
}

Task66();