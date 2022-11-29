// Программа задает массив заполненный случайными положительными трёхзначными числами и показывает количество чётных чисел в массиве.

Console.Clear();

int[] array = Fillmassive();
Console.WriteLine("Массив создан согласно условиям задачи: " + String.Join(" ", array)); //выведем на экран созданный массив
int number = PrinNumberPositiveIntMassive(array);
Console.WriteLine($"Количество четных чисел в массиве равно {number}");


int[] Fillmassive()
{
    int x = new Random().Next(3,10);
    int[] res = new int[x];
    for(int i = 0; i < x; i++) 
    {
        res[i] = new Random().Next(100,999);
    }
    return res;
}

int PrinNumberPositiveIntMassive(int[] array)
{
    int res = 0;
    for (int i =0; i < array.Length; i++)
    {
        if ( array[i] % 2 == 0)
        {
            res++;
        }
    }
    return res;
}