// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string Palindrom(int num)
{
    string result = "да";
    if (num <= 99999 && num >= 10000)
    {
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
        
    }
    else
        result = "Введите пятизначное число!!";
    return result;
}




Console.Write("Введите пятизначное число: ");
try
{
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(Palindrom(n));
}
catch
{
    Console.WriteLine("Введите пятизначное число!!");
}


