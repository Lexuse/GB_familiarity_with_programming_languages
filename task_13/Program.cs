// программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int number1; 
int the3Number;


while (true)
{    
    Console.WriteLine ("введите пожалуйста целое чило");
    if (int.TryParse(Console.ReadLine(), out number1))
        break;
    Console.WriteLine("ошибка ввода! нужно вводить нужно целое число!");
}


while (number1 > 999) //с помощю этого цикла мы ограничим любое число до трехзначного
{
    number1 = number1 / 10;
}

if (number1 > 99)
{       
    the3Number = number1 % 10;
    Console.WriteLine($"{number1} -> {the3Number}");
}
else
    Console.WriteLine($"{number1} -> третьей цифры нет");
