// Программа создает массив вещественных чисел и находит разницу между максимальным и минимальным элементов массива.

Console.ReadLine();

int[] array  = CreateArray();
Console.WriteLine("Массив создан согласно условиям задачи: " + String.Join(" ", array)); //выведем на экран созданный массив

int result = Difference(array);
Console.WriteLine($"разница между максимальным и минимальным элементов массива равна {result}");

int[] CreateArray()
{
    int size = new Random().Next(5, 15);
    int[] arr = new int[size];
    for(int i =0; i < arr.Length; i++)
    {
        arr[i] =  new Random().Next(1, 100);
    }
    return arr;
}

int Difference (int[] array)
{
    int min = array.Min();
    int max = array.Max();
    int res = max - min;
    return res;   
}