// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

string Palindrom(int num)
{
    string result = "да";
    int index = 5;
    int[] arrayA = new int[index];
    int[] arrayB = new int[index];
    for (int i = 0; i < index; i++)
    {
        arrayA[i] = num % 10;
        num/=10;
    }
    arrayB = Enumerable.Reverse(arrayA).ToArray();

    for  (int i = 0; i < index; i++)
    {
        if (arrayA[i] != arrayB[i])
        {
            result = "нет";
            break;
        }
    }
    return result;
}



Console.Write("Введите пятизначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Palindrom(n));