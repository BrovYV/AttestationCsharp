// Задача 3: Задайте произвольный массив. Выведете его элементы, 
// начиная с конца. Использовать рекурсию, не использовать циклы.


int[] CreateArrayRndInt(int size)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(1, 100);
    }

    return array;
    
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{array[i]}, ");
        }
        else
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}


void TurnArray(int[] array, int count = 1)
{
    if (array.Length == count - 1)
    {
        return;
    }
    Console.Write($"{array[array.Length - count]} ");
    TurnArray(array, count + 1);

}

Console.WriteLine("Enter size:");
int[] arr = CreateArrayRndInt(Convert.ToInt32(Console.ReadLine()));
PrintArray(arr);
Console.WriteLine();
TurnArray(arr);