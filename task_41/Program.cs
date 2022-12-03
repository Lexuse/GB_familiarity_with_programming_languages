// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();
int userAmmountInputNumb = GetUserInputNumber("Введите кличество требуемых чисел :", "Ошибка ввода!");

int[] arrayUserInput = FillArray(userAmmountInputNumb);
Console.WriteLine("Вы ввели числа: " + string.Join(" ", arrayUserInput));

int greatThenZero = Calc(arrayUserInput);
Console.WriteLine($"Вы ввели {greatThenZero} чисел больше нуля");



//////////////////////////////////////////////////////////
int GetUserInputNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        
        if (int.TryParse(Console.ReadLine(), out int userInpNumb))
            return userInpNumb;
        else 
        Console.WriteLine(errorMessage);
    }
}


int[] FillArray(int arrLenth)
{
    int[] array = new int [arrLenth] ;
    for (int i =0; i < arrLenth; i++)
    {
        array[i] =  GetUserInputNumber("Введите число :", "Ошибка ввода!");
    }
    return array;
}


int Calc(int[] arr)
{
    int res = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) ++res;
    }
    return res;
}