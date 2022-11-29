// Программа задает одномерный массив, заполненный случайными числами и находит сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] array = CreateArray();
Console.WriteLine("Массив создан согласно условиям задачи: " + String.Join(" ", array)); //выведем на экран созданный массив
int summ = SummElements(array);
Console.WriteLine($"сумма элементов, стоящих на нечётных позициях равна {summ}");


int[] CreateArray()
{
    int size = new Random().Next(10, 15);
    int[] arr = new int[size];
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] =  new Random().Next(-10000, 10000);
    }
    return arr;
}


int SummElements (int[] array)
{
    int summ = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 != 0) summ += array[i];
    }
    return summ;
}

