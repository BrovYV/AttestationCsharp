// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N. 
// Использовать рекурсию, не использовать циклы.




void DigitsBetweenNumbersMN(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write(num1);
        return;
    }
    Console.Write($"{num1}, ");
    DigitsBetweenNumbersMN(num1 + 1, num2);

}

void DigitsBetweenNumbersNM(int num1, int num2)
{
    if (num1 == num2)
    {
        Console.Write(num2);
        return;
    }
    Console.Write($"{num1}, ");
    DigitsBetweenNumbersNM(num1 - 1, num2);

}

void PrintDigitsBetweenNumbers(int num1, int num2)
{
    if (num1 > num2)
    {
        DigitsBetweenNumbersNM(num1, num2);
    }
    else if (num1 < num2)
    {
        DigitsBetweenNumbersMN(num1, num2);
    }
    else
    {
        Console.Write(num1);
    }
}

Console.WriteLine("Введите первое число:");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число:");
int n = Convert.ToInt32(Console.ReadLine());
PrintDigitsBetweenNumbers(m, n);

