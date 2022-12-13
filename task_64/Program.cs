// Задайте значение N. Напишите прграмму, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсиии

Console.Clear();

int n = GetInputUserNumber("ВВедите натуральное число" , "Ошибка ввода!");

int end = 1;
string result = MyRecursionMethod(n);

Console.WriteLine(result);


/////////////////////////////////////////
int GetInputUserNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.WriteLine($"{message}");
        if (int.TryParse(Console.ReadLine(), out int mumber))
            return mumber;
        Console.WriteLine($"{errorMessage}");
    }
}


string MyRecursionMethod (int n)
{
    if(end == n)
    {
        return end.ToString();
    }
    return n + " " + MyRecursionMethod(n - 1);   
}