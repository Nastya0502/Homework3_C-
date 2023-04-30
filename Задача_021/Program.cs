// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Rasst3D(int ax, int ay, int az, int bx, int by, int bz)
{
    return Math.Round(Math.Sqrt(Math.Pow((bx - ax), 2) + Math.Pow((by - ay), 2) + Math.Pow((bz - az), 2)), 2);
}



try
{
    Console.Write("Введите координату x точки А: ");
    int ax = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y точки А: ");
    int ay = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z точки А: ");
    int az = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату x точки B: ");
    int bx = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату y точки B: ");
    int by = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите координату z точки B: ");
    int bz = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Rasst3D(ax, ay, az, bx, by, bz));
}
catch
{
    Console.WriteLine("Вводите только целые числа!");
}
