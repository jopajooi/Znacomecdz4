// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Clear();
System.Console.WriteLine("Enter number 1:  ");
int n1 = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter nuber 2:  ");
int n2 = Convert.ToInt32(Console.ReadLine());
int degree()
{
    int a = (int)Math.Pow(n1, n2);

    return a;
}
System.Console.WriteLine(degree());
