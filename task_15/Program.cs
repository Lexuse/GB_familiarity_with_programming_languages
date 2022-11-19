//программа, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет


int number; 

while (true)
{    
    Console.WriteLine ("Введите пожалуйста день недели, цифрой от однго до 7");
    if (int.TryParse(Console.ReadLine(), out number))
        break;
    Console.WriteLine("ошибка ввода! введите цифру соответсвующую дню недели!");
}

 if (number < 0 || number > 7)
    {
        Console.WriteLine($"{number} это вообще не день недели ");
    }
    else if (number > 0 && number < 8)

    if (number > 5)
    {
        Console.WriteLine("да");
    }
    else        
         Console.WriteLine("нет");
    

