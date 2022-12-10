// Составить частотный словарь элеметов двухмерного массива.
// Частотный словарь содержит информацию о том, сколько раз встречается эдемет входных данных

Console.Clear();

int rowInArray = GetInputUserNumber ("Введите требуемое количество строк массива" ,"Ошибка ввода!");
int collumnInArray = GetInputUserNumber ("Введите требуемое количество столбцов массива" ,"Ошибка ввода!");
int minValueInMassive = GetInputUserNumber ("Введите минимальное значение элементав массиве " ,"Ошибка ввода!");
int maxValueInMassive = GetInputUserNumber ("Введите максимальное значение элементав массиве " ,"Ошибка ввода!");
int serchElement = GetInputUserNumber("Введите искомый элемент массива. Это должно быть целое число ","Ошибка ввода!");

int[,] array = GenerateArray(rowInArray, collumnInArray, minValueInMassive,maxValueInMassive);
PrintArray(array);
int searchedResult = SearchElementsInArray(array);
PrintResults(searchedResult);



//////////////////////////////////////////////////////
int GetInputUserNumber (string message, string errorMessage)
{
    while(true)
    {
        Console.WriteLine($"{message}");
        if(int.TryParse(Console.ReadLine(), out int number))
            return number;
        Console.WriteLine(errorMessage);
    }
}

int[,] GenerateArray(int row, int col, int minValue, int maxValue)
{
    int[,] arr = new int[row,col];
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(minValue,maxValue);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

int SearchElementsInArray(int[,] arr)
{
    int ammount = 0;
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if ( arr[i,j] == serchElement) ++ammount;            
        }
    }
    return ammount;
}

void PrintResults(int numb)
{
    Console.WriteLine($"искомый элемент представленный числом {serchElement}  - встречается в массиве {searchedResult} раз");
}