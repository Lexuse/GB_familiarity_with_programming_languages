//Задайте двумерный массив. Напишите программу, которая меняет местами первую и последнюю строку массива

Console.Clear();

int[,] array = GenerateArray(5,5);
PrintArray(array);
Console.WriteLine("#############");
ChangeArrayRows(array);
PrintArray(array);

////////////////////////////////////////
int[,] GenerateArray(int row, int col)
{
    int[,] arr = new int[row,col];
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < col; j++)
        {
            arr[i,j] = new Random().Next(1,9);
        }    
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

void ChangeArrayRows(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {   
        int temp = arr[0,j]; //сохранили значение 1го элемента в первой строке
        arr[0,j] = arr[arr.GetLength(0) -1, j]; //заменили значение первого элемента в строке значением первого элемента в последней строке
        arr[arr.GetLength(0) - 1, j] = temp; // присволили значение первого элемента в первой строке первому элементу в последней строке, которое ранее было сохранено в temp
    }
}