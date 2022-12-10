// Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Clear();

int userInputNumber;
int output;


while (true)
{
    Console.WriteLine("Введите пожалуйста число");
    if (int.TryParse(Console.ReadLine(), out userInputNumber))
       break;
    Console.WriteLine("Ошибка ввода, введите пожалуста число");
}


Cube (userInputNumber);


void Cube (int userInputNumber)
{
    int iterator = 1;
    while (iterator <= userInputNumber)
    {
        output = Convert.ToInt32(Math.Pow(iterator, 3));
        Console.Write($"{output}, ");
        iterator++;
    }
}



    