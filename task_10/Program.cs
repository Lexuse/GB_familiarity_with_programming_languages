//Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

int inputNumber; 

while (true)
{    
    Console.WriteLine ("введите пожалуйста целое трехзначное чило");
    if (int.TryParse(Console.ReadLine(), out inputNumber))
        break;
    Console.WriteLine("ошибка ввода! нужно вводить цифры");
}

int a = inputNumber / 10;
int b = a % 10;

Console.WriteLine ($"{inputNumber} -> {b}");