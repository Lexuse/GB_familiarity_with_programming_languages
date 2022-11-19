//программа принимает на вход число а на выходе показывает все четные сила из его диапазона

Console.WriteLine("Введите число и програма выведет все четные числа в его множестве");

int number = int.Parse(Console.ReadLine());


for ( int i = 1; i <= number; i ++ )
{
    if (i % 2 == 0) Console.WriteLine ($"{number} -> {i}");    
}
