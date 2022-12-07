// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4

Console.Clear();

int posElementsRow = GetUserInputNumber("Введите искомую позицию элемента в строке матрицы", "Ошибка ввода!");
int posElementsCollumn = GetUserInputNumber("Введите искомую позицию элемента в столбце матрицы", "Ошибка ввода!");

int[,] array = CreateArray(5,5);

PrintArray(array);

FindPositionInArr(array, posElementsRow, posElementsCollumn);


///////////////////////////////////////////
int GetUserInputNumber(string message, string errorMessage)
{
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out int number))
            return number;
        Console.WriteLine(errorMessage);
    }
}



int[,] CreateArray(int row, int collumn)
{
    int[,] arr = new int [row, collumn];

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collumn; j++)
        {
            arr[i, j] = new Random().Next(1, 99);
        }
    }
    return arr;
}



void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j ++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}



void FindPositionInArr(int[,] arr, int findRow, int findCollumn)
{
    if (findRow > arr.GetLength(0) - 1 || findCollumn > arr.GetLength(1) - 1)
    {
        Console.WriteLine("Такой позиции в массиве нет");

        posElementsRow = GetUserInputNumber("Если вы хотите продолжить, введите новый номер строки или отрицательное число для выхода из программы", "Ошибка ввода!");

        if (posElementsRow > 0)
        {
            posElementsCollumn = GetUserInputNumber("Введите новый номер столбца ","Ошибка ввода!");

            FindPositionInArr(array, posElementsRow, posElementsCollumn);
        }
    }
    
    else Console.WriteLine($"Искомое число на строке {findRow} и столбце {findCollumn} -> {arr[posElementsRow, posElementsCollumn]}");

}