// Программа замены элементов массива: положительные элементы заменяются отрицательными и наоборот

Console.Clear();

int amountElementsOfMassive = GetUserInputNumber ("Задайте размер массива ", "Ошибка ввода! ");
int minValueofMassive = GetUserInputNumber ("Задайте минимальное значение массива ", "Ошибка ввода! ");
int maxValueofMassive = GetUserInputNumber ("Задайте максимальное значение массива ", "Ошибка ввода! ");

int[] array = GetArray(amountElementsOfMassive, minValueofMassive, maxValueofMassive);
Console.WriteLine("Массив сенерирован согласно заданным условиям: " + String.Join(" ", array)); //выведем на экран созданный массив

int[] resArray = ChangeArray(array);
Console.WriteLine("Массив обработан согласно условиям задачи: " + String.Join(" ", resArray)); //выведем на экран созданный массив




////////////////////////////////////////////
//Метод получения числа введенного пользователем
int GetUserInputNumber (string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);

        if (int.TryParse(Console.ReadLine(), out int userInpNumb))
            return userInpNumb;
        
        Console.WriteLine(errorMessage);
    }
}

//Метод создания массива с заданными параметрами
int[] GetArray (int amountElementsOfMassive, int minValueofMassive, int maxValueofMassive)
{
    int[] res = new int [amountElementsOfMassive];

    for (int i = 0; i < amountElementsOfMassive; i++)
    {
        res[i] = new Random().Next(minValueofMassive, maxValueofMassive + 1);
    }
    return res;
}

int[] ChangeArray (int[] array)
{
    int[] res = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        res[i] = array[i] *= -1;  
    }
    return res;
} 