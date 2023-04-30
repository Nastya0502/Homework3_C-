// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string Cube(int n)
{
    string result = "";
    for (int i =1; i < n; i++)
    {
        result += Convert.ToString(Math.Pow(i, 3)) + ", ";
    }
    result += Convert.ToString(Math.Pow(n, 3));
    return result;
}

try
{
    Console.Write("Введите целое число n: ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Cube(num));
}
catch
{
    Console.WriteLine("Введите целое число!");
}