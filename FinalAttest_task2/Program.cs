// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


int AckermanFunc(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return AckermanFunc(n - 1, 1);
    }
    else
    {
        return AckermanFunc(n - 1, AckermanFunc(n, m - 1));
    }
}

Console.WriteLine("Введите первое число:");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int m = Convert.ToInt32(Console.ReadLine());

int result = AckermanFunc(n, m);
Console.WriteLine($"(Результат выполнения функции Аккермана: {result})");