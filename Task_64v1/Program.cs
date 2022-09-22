// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void Task64()
{
    Console.WriteLine("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(IntervalNaturalNumbers(numberM, numberN));
}

string IntervalNaturalNumbers(int m, int n)
{
    if (m == n)
    {
        return n.ToString();
    }
    else if (m > n)
    {
        return (m + " " + IntervalNaturalNumbers(m - 1, n));
    }
    else
    {
      return (m + " " + IntervalNaturalNumbers(m + 1, n));
    }
    
}

Task64();