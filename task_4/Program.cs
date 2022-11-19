
    int max =0;

    Console.Write ("Программа, которая принимает на вход три числа и выдает максимальное из этих чисел");
    Console.WriteLine ("Введите подряд три числа для получения результата. Нажимайте интер после каждого ввода");

    int number1 = int.Parse (Console.ReadLine());
    int number2 = int.Parse (Console.ReadLine());
    int number3 = int.Parse (Console.ReadLine());

    max = number1;

    if (number2 > max) max = number2;
    if (number3 > max) max = number3;


    Console.Write ($"{number1}, {number2}, {number3}, -> {max}" );
   

