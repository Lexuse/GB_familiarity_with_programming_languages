// Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. В случае если это невозможно, программа должна вывести сообщение для пользователя

Console.Clear();

int[,] array = GenerateArray(5,5);
PrintArray(array);
Console.WriteLine("#############");
int[,] reverseArray = ChangeArray(array);
PrintArray(reverseArray);


//////////////////////////
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

int[,] ChangeArray(int[,] arr)
{
    int[,] revArray = new int[arr.GetLength(1), arr.GetLength(0)];
    for(int i = 0; i < revArray.GetLength(0); i++)
    {
        for(int j = 0; j < revArray.GetLength(1); j++)
        {
            revArray[i,j] = arr[j,i];
        }
    }
    return revArray;
}