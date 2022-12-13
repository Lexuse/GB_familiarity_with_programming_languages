// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

int m = GetInputUserNumber("Введите натуральное число M", "Ошибка ввода!");
int n = GetInputUserNumber("Введите натуральное число N", "Ошибка ввода!");


int temp = m;

if (m > n)
{
    m = n;
    n = temp;
}
Console.Write($"{m}, {n} ->");
PrintSum(m, n, temp = 0);

////////////////////////////////////////////////////////
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


void PrintSum(int m, int n, int sum)
{
    sum = sum + n;
    if (n <= m)
    {
        Console.Write($" {sum} ");
        return;
    }
    PrintSum(m, n - 1, sum);

}
