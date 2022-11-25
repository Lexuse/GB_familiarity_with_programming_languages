// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.Clear();

int[] array = {23, 12, 2, 0, 33, 12, 32, 1};



PrintArray(array);



////////////////////////////////////
void PrintArray(int[] array)
{
  int coll = array.Length;
  Console.Write("[");
  for(int i = 0; i < coll; i++)
  {
    if(i < coll -1)
     Console.Write($"{array[i]}, ");
    else
      Console.Write($"{array[i]}");
  }
  Console.Write("]");
}