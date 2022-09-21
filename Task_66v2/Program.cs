// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

void Task66()
{
    Console.WriteLine("Введите число M: ");
    int numberM = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите число N: ");
    int numberN = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine();
    Console.WriteLine($"Сумму натуральных элементов в промежутке от {numberM} до {numberN} = {TheSumOfNaturalElements(numberM, numberN)}");
}

int TheSumOfNaturalElements(int m, int n)
{
    int result = m;
    if (m < n)
    {
        while (m < n)
        {
            m += 1;
            result += m;
        }
        return result;
    }
    else
    {
        while (n < m)
        {
            m -= 1;
            result += m;
        }
        return result;
    }
}

Task66();
