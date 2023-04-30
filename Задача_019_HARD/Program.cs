// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

string Palindrom(int num)
{
    string result = "да";
    int numReverse = 0;
    int num_isp = num;
    while (num_isp > 0)
    {
        numReverse = numReverse * 10 + num_isp % 10;
        num_isp /= 10;
    }
    if (numReverse != num)
    {
        result = "нет";
    }
    return result;
}




Console.Write("Введите число: ");
try
{
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Palindrom(n));
}
catch
{
    Console.WriteLine("Введите целое число!!");
}