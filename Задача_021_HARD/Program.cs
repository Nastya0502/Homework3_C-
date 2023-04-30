// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

double RasstND(int n)
{
    int[] arrayA = new int[n];
    int[] arrayB = new int[n];
    double summ = 0;
    double result = 0;
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} координату точки A: ");
        arrayA[i] = Convert.ToInt32(Console.ReadLine());
    }

    for (int i = 0; i < n; i++)
    {
        Console.Write($"Введите {i + 1} координату точки B: ");
        arrayB[i] = Convert.ToInt32(Console.ReadLine());
    }
    for (int i = 0; i < n; i++)
    {
        summ += Math.Pow((arrayB[i] - arrayA[i]), 2);
    }
    result = Math.Round(Math.Sqrt(summ), 2);
    return result;
}

try
{
    Console.Write("Введите размерность пространства: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(RasstND(num));
}
catch
{
    Console.WriteLine("Введите целое число!!");
}
