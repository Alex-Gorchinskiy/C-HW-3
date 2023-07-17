// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

void ShowDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double distance = Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2));
    Console.WriteLine($"Расстояние между двумя точками: {distance}!");
}
    int GetInput(string text)
    {
        Console.Write(text);
        return Convert.ToInt32(Console.ReadLine());
    }

    int ax = GetInput("Введите координаты Х точки А: ");
    int ay = GetInput("Введите координаты Y точки А: ");
    int az = GetInput("Введите координаты Z точки А: ");
    int bx = GetInput("Введите координаты Х точки B: ");
    int by = GetInput("Введите координаты Y точки B: ");
    int bz = GetInput("Введите координаты Z точки B: ");

ShowDistance(ax, ay, az, bx, by, bz);


// Второй вариант решения, подсмотрел в интернете



// double x1 = GetCoordinate("Введите координату X точки A: ");
// double y1 = GetCoordinate("Введите координату Y точки A: ");
// double z1 = GetCoordinate("Введите координату Z точки A: ");

// double x2 = GetCoordinate("Введите координату X точки B: ");
// double y2 = GetCoordinate("Введите координату Y точки B: ");
// double z2 = GetCoordinate("Введите координату Z точки B: ");

// double distance = CalculateDistance3D(x1, y1, z1, x2, y2, z2);

// Console.WriteLine("Расстояние между точками A и B: " + distance.ToString("F2"));

// static double GetCoordinate(string prompt)
// {
//     Console.Write(prompt);
//     double coordinate = double.Parse(Console.ReadLine());
//     return coordinate;
// }

// static double CalculateDistance3D(double x1, double y1, double z1, double x2, double y2, double z2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
//     return distance;
// }