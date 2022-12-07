//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9
Console.Clear();

int row = GetUserNumber("введите желаемое количество строк ", "ошибка ввода! ");
int collum = GetUserNumber("введите желаемое количество столбцов ", "ошибка ввода! ");
int minValue = GetUserNumber("Введите минимаоьное число для генерации ", "ошибка ввода!");
int maxValue = GetUserNumber("Введите максимальное число для  генерации ", "ошибка ввода!");

double[,] array = FillArray(row, collum, minValue, maxValue);

PrintArray(array);




//////////////////////////////////////////////
int GetUserNumber(string text, string error)

{
    while (true)
    {
        Console.WriteLine(text);

        if (int.TryParse(Console.ReadLine(), out int number))
            return number;

        Console.WriteLine(error);
    }
}

double[,] FillArray(int row, int collum, int minValue, int maxValue)
{
    double[,] res = new double[row, collum];
    
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < collum; j++)
        {
            var random = new Random();
            double randDoubValue = random.NextDouble();  //выполняет генрацию числа от 0 до 1
            res[i,j] = Math.Round((randDoubValue * (maxValue - minValue) + minValue), 2);
            
        }
    }

    return res;
}

void PrintArray(double[,] inArray)
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