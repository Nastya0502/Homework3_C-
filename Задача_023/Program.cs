// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

string Cube(int n)
{
    int index = 1;
    string result = "";
    while (index < n)
    {
        result += Convert.ToString(Math.Pow(index, 3)) + ", ";
        index++;
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