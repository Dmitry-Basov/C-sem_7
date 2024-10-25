// : Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Используйте рекурсию и не используйте циклы.
// Пример:
// ● Вход: M = 1, N = 5
// ● Выход: 1, 2, 3, 4, 5
// ● Вход: M = 4, N = 8
// ● Выход: 4, 5, 6, 7, 8



void PrintRange(int m, int n)
{
    if (m > n)
    {

        PrintRange(m - 1, n);
        Console.Write($"{m}, ");
    }

    else if (m < n)
    {
        PrintRange(n - 1, m);
        Console.Write($"{n}, ");
    }

}



Console.WriteLine("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Числа в промежутке: ");
PrintRange(m, n);

// if (m > n)
//     {
//         PrintRange(m - 1, n);
//         Console.Write($"{m}, ");
//     }

//     else if (m < n)
//     {
//         PrintRange(n- 1, m);
//         Console.Write($"{n}, ");
//     }