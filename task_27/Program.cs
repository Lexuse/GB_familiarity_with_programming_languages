// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
int number = userInputNumber("Введите число  ","Ошибка ввода!  ");
int res =0;



while (number > 0)
{
   res += number % 10;
   number /= 10;
}


Console.Write($"{res}");


////////////////////////////////////////////////////////
int userInputNumber (string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userInpNumb))
            return userInpNumb;
        
        Console.WriteLine(errorMessage);
    }
}
