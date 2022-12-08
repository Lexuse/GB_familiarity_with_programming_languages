//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();

int row = GetUserInputNumber("Введите количество строк для генерации двумерного массива ", "Ошибка ввода!");
int collumn = GetUserInputNumber("Введите количество столбцов для генерации двумерного массива ", "Ошибка ввода!");

int[,] array = GenerateArray(row, collumn);
PrintArray(array);
double[] average = FindAverageInCollumn(array);

Console.WriteLine(String.Join("  ", average));



//////////////////////////////////////////
int GetUserInputNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out int number))
            return number;
        Console.WriteLine(errorMessage);
    }
}

int[,] GenerateArray (int row, int col)
{
    int[,] array = new int[row,col];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            array [i,j] = new Random().Next(1,99);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {array[i,j]}");
        }
        Console.WriteLine();
    }
}

double[] FindAverageInCollumn (int[,] arr)
{
        double[] aver = new double[arr.GetLength(1)];
        double summ = 0;

    for (int j = 0; j < arr.GetLength(1); j++)
    {
       
        for (int i = 0; i < arr.GetLength(0); i++) summ += arr[i, j];
            summ /= arr.GetLength(0);
            aver[j] = Math.Round(summ, 2);
        
    }
    return aver;    
}