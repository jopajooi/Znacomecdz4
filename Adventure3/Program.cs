// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]



Console.Clear();

int n;
Console.Write("Введите количество элементов массива:   ");

n = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите элементы массива через пробел:  ");

int body()
{
    int[] a = new int[n];
    for (int i = 0; i < n; i++)
    {
        a[i] = int.Parse(Console.ReadLine()!);

    }
    Console.Write("\nМассив: {0}", "[");
    Console.Write(String.Join(", ", a));
    Console.Write("]");
    return body();
}

System.Console.WriteLine(body());
