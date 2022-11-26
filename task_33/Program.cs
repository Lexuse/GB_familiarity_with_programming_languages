// Программа, которая задает массив на пользовательских уловиях и определяет наличие искомого числа.

Console.Clear();

int arraySize = InputUserNumber("Введите размер массива ", "Ошибка ввода! ");
int minValueofMassive = InputUserNumber("Введите минимальное значение в массиве ", "Ошибка ввода! ");
int maxValueofMassive = InputUserNumber("Введите максимальное значение в массиве ", "Ошибка ввода! ");
int searchNmber = InputUserNumber("Введите искомое значение в массиве ", "Ошибка ввода! ");

int[] array = GenerateArray(arraySize, minValueofMassive, maxValueofMassive);
Console.WriteLine("программа выполнит поиск числа " + searchNmber + " в сгенерированном массиве [" +  String.Join(" ", array) + "]");

string answer = SearchInMassive(searchNmber, array);
Console.WriteLine($"ответ {answer}");






//////////////////////////////////////////////////////////
//Метод получения числа методом ввода с клавиатуры
int InputUserNumber(string message, string errorMessage)
{
    Console.WriteLine(message);
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out int userInpNumb))
            return userInpNumb;

        Console.WriteLine(errorMessage);
    }
}


//Метод генерирующий массив согласно полученным параметрам
int[] GenerateArray(int arraySize, int minValueofMassive, int maxValueOfMassive)
{
    int[] res = new int[arraySize];
    for(int i = 0; i < arraySize; i++)
        res[i] = new Random().Next(minValueofMassive, maxValueofMassive +1);
    return res;
}

//Метод поиска заданного числа в массиве. отдает ответ в виде строки
string SearchInMassive(int searchNmber, int[] array)
{
    string res = String.Empty;
    for (int i = 0 ; i < arraySize; i++)
    {
        if (array[i] == searchNmber) return $"да, число {searchNmber} присутсвет в массиве";
    } 
    return "нет, такого числа в массиве нет";  
}