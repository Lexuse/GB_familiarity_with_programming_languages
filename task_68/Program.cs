//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29

Console.Clear();

int m = GetInputUserNumber("Введите натуральное число M", "Ошибка ввода!");
int n = GetInputUserNumber("Введите натуральное число N", "Ошибка ввода!");

int akkermanFunc = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunc} ");



///////////////////////////////////////////////////////////
int GetInputUserNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine($"{message}");
        if ((int.TryParse(Console.ReadLine(), out int number)) && number > 0)
            return number;
        Console.WriteLine($"{errorMessage}");
    }
}


int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    else
    {
        return Akkerman(m - 1, Akkerman(m, n - 1));
    }
}


