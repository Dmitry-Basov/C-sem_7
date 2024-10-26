// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.



void PrintArrReverse(int[] array, int index)
{
    Console.Write(array[index]);
    
    if (index < 0) return;

    if (index > 0)
    {
        Console.Write(", ");
        PrintArrReverse(array, index - 1);
    }
}

int[] arr = { 1, 9, 3, 4, 5 };
Console.WriteLine("Массив в обратном порядке");
PrintArrReverse(arr, arr.Length - 1);