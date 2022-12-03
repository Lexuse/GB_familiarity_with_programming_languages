//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("input b1:");
double b1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k1:");
double k1=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input b2:");
double b2=Convert.ToDouble(Console.ReadLine());
Console.WriteLine("input k2:");
double k2=Convert.ToDouble(Console.ReadLine());


PrintResult(b1, b2, k1, k2);



////////////////////////////////////////////////////////
void PrintResult(double b1, double b2, double k1, double k2)
{
double xIntersection=0;
double yIntersection=0;
if (b1==b2 & k1==k2) Console.WriteLine("Данные прямые совпадают");
else if (k1==k2) Console.WriteLine("Прямые параллельны ");
else 
{
    xIntersection =(b2-b1)/(k1-k2);
    yIntersection =k1*xIntersection+b1;
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} ->  точка пересечения "+" ("+ xIntersection+" ;"+yIntersection+ ")");
}
}
  