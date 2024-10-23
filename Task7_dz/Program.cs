// Задайте произвольный массив. Выведите его элементы, начиная с конца.
// Используйте рекурсию и не используйте циклы.



void PrintArrayReverse(int[] array, int index)
{
    if (index < 0) return;
    {
        Console.Write(array[index]);
    }
    if (index > 0)
    {
        Console.Write(", ");
        PrintArrayReverse(array,index -1);
    }
}

int[] arr = {1,2,3,4,5};
Console.WriteLine("Массив в обратном порядке");
PrintArrayReverse(arr, arr.Length - 1);