// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

void Task68()
{
    Console.WriteLine("Введите неотрицательное число m: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Введите неотрицательное число n: ");
    int n = Convert.ToInt32(Console.ReadLine());

    Console.Write($"A(m,n) = {AckermanFunction(m, n)} ");
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;                                                   //  A(0, n) = n + 1
    }
    else if (m > 0 & n == 0)
    {
        return AckermanFunction(m - 1, 1);                              //  A(m, 0) = A(m - 1, 1)
    }
    else
    {
        return (AckermanFunction(m - 1, AckermanFunction(m, n - 1)));   //  A(m, n) = A(m - 1, A(m, n - 1))
    }
}

Task68();
