// Напишите программу для вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// Пример:
// ● Вход: m = 2, n = 3
// ● Выход: A(m, n) = 29
// ● Вход: m = 1, n = 4
// ● Выход: A(m, n) = 7



int Ancermanfunction(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return Ancermanfunction(n - 1, 1);
    }
        return Ancermanfunction(n - 1, Ancermanfunction(n, m - 1));
    
}

int m = 2;
int n = 3;


int result = Ancermanfunction(n, m);
Console.Write($"A({m}, {n}) = {result} ");