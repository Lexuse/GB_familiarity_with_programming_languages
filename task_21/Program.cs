// Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();
double distance;

double x1 = UserInput("Введите координату x1: ");
double y1 = UserInput("Введите координату y1: ");
double z1 = UserInput("Введите координату z1: ");

double x2 = UserInput("Введите координату x2: ");
double y2 = UserInput("Введите координату y2: ");
double z2 = UserInput("Введите координату z2: ");

distance = DisPoint(x1, y1, z1, x2, y2, z2);

Console.WriteLine($"A({x1},{y1},{z1}); B({x2},{y2},{z2}), -> {distance}");

static double DisPoint(double x1, double y1, double z1, double x2, double y2, double z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}


//метод, принимающий на вход просьбу вести заданную координату и возвращающий её double значение
static double UserInput (string message)
{
    Console.Write(message);
    return double.Parse(Console.ReadLine() ?? "");
}