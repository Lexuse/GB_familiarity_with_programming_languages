//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();
int res = 1;

int  userNuberA = GetNumberFomUser ("Введите число A  ", "Ошибка ввода!");
int  userNuberB = GetNumberFomUser ("Введите число B  ", "Ошибка ввода!");



for (int i = 1; i <= userNuberB; i++)
{    
    res *= userNuberA;
}

Console.Write($"{userNuberA}, {userNuberB} -> результат равен {res} ({userNuberA} в степени {userNuberB})");





/////////////////////////////////
int GetNumberFomUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        
        Console.WriteLine(errorMessage);
    }
}