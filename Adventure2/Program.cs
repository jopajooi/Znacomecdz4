
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.Clear();
System.Console.WriteLine("Enter number :  ");
int n = Convert.ToInt32(Console.ReadLine());

int Sum()
{

    int sum = 0;

    for (int i = 3; i >= 0; i--)
    {
        sum += n / (int)Math.Pow(10.0, i);
        n = n % (int)Math.Pow(10.0, i);
    }
    return sum;


}

System.Console.WriteLine(Sum());
