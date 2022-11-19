{
    int max =0;

    Console.WriteLine ("Программа, которая сравнивает 2 числа");

    Console.WriteLine ("Введите первое число");
    int number1 = int.Parse (Console.ReadLine ());

    Console.WriteLine ("Введите второе число");
    int number2 = int.Parse (Console.ReadLine ());

    if (number1 > number2) max = number1;
    else max = number2;

    Console.Write ($"a = {number1}, b = {number2}, max = {max}");

}
 