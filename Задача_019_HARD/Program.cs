// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

string Palindrom(int num)
{
    int num_isp=num;
    string result = "да";
    int index = 0;
    
    while (num_isp>0)
    {
        num_isp/=10;
        index++;
    }
    
    int[] arrayA = new int[index];
    int[] arrayB = new int[index];

    for (int i = 0; i < index; i++)
    {
        arrayA[i] = num % 10;
        num/=10;
    }
    // arrayB = Enumerable.Reverse(arrayA).ToArray();

    // Переворот массива А вручную
    for (int i = 0; i<index; i++)
    {
        arrayB[i] = arrayA[index-i-1];
    }

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