//  54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
//  Например, задан массив:
//  1 4 7 2
//  5 9 2 3
//  8 4 2 4
//  В итоге получается вот такой массив:
//  7 4 2 1
//  9 5 3 2
//  8 4 4 2

Console.Clear();

int row = GetInputUserNumber("Введите количество строк в массиве ", "Ошибка ввода");
int collumn = GetInputUserNumber("Введите количество столбцов в массиве ", "Ошибка ввода");
int minValue = GetInputUserNumber("Введите минимаоьное значение в массиве ", "Ошибка ввода");
int maxValue = GetInputUserNumber("Введите максимальное значение в массиве ", "Ошибка ввода");

int[,] array = GenerateArray(row, collumn, minValue, maxValue);
PrintArray(array);
Console.WriteLine($"#######################");
ChangeArray(array);

/////////////////////////////////////////////////////////////////
int GetInputUserNumber(string message, string errorMessage)
{
    while(true)
    {
        Console.WriteLine($"{message}");
        if (int.TryParse(Console.ReadLine(), out int mumber))
            return mumber;
        Console.WriteLine($"{errorMessage}");
    }
}

int[,] GenerateArray(int row, int col, int minValue, int maxValue)
{
    int[,] arr = new int[row,col];
    for(int i = 0; i < arr.GetLength(0); i ++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return arr;
}

void PrintArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j =0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]}  ");
        }
        Console.WriteLine();
    }
}

//метод, который частично реализует сортировку пузырьком двумерного массива в столбцах. Делегирует часть работы другому методу "Swap"
void ChangeArray(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            for(int k = 0; k < arr.GetLength(1) -1; k++)
            {
                if(arr[j, k] < arr[j, k+1])
                {
                    Swap(ref arr[j , k], ref arr[j, k + 1]);
                }               
            }
            Console.Write($"{arr[i , j]}  ");                                
        }
       Console.WriteLine();                  
    }  
    
}

// Вспомогательный метод, который меняет местами входящие аргументы
static void Swap (ref int firstArg, ref int secondArg)
{
    //Временная переменная, хранит значение первого элемента
    int tmp = firstArg;

    //Первый элемент получил значение вторго
    firstArg = secondArg;

    //Второй элемент получил значение первого
    secondArg = tmp;
}