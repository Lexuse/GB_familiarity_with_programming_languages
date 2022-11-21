//Программа которая принимает на вход пятизначное число и проверяет, является ли оно полиндромом

Console.Clear();
int userInput5Number = 0;
int reverse = 0;


    try
    {
        Console.WriteLine ("введите пятизначное число для проверки его на соответсвие палиндрому");
        userInput5Number = int.Parse(Console.ReadLine() ?? ""); //сразу выполним проверку на Null
    }
    catch(Exception exc)
    {
        Console.WriteLine ($"Ошибка ввода данных! Ведите пятизначное число {exc.Message}");
    }

    reverse = Reverse5UserNumber(userInput5Number);

    if (userInput5Number == reverse)
            Console.WriteLine($"{userInput5Number} -> да");
        else
            Console.WriteLine($"{userInput5Number} -> нет");




static int Reverse5UserNumber (int userInput5Number) //создадим метод, который переворачивает введенное число
{
int a; 
int reverse = 0;      //просто переменная для хранения временного значения
a = userInput5Number % 10;
userInput5Number = userInput5Number / 10;
reverse += a * 10000;

a = userInput5Number % 10;
userInput5Number = userInput5Number / 10;
reverse += a * 1000;

a = userInput5Number % 10;
userInput5Number = userInput5Number / 10;
reverse += a * 100;

a = userInput5Number % 10;
userInput5Number = userInput5Number / 10;
reverse += a * 10;

a = userInput5Number % 10;
userInput5Number = userInput5Number / 10;
reverse += a;

//Console.WriteLine(reverse);
return reverse;
}