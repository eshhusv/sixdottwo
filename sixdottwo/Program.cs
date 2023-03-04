using ClassLibrary1;
using System;

int[,] a = new int[5, 8];

for (int i = 0; i < a.GetLength(0); i++)

{

    for (int j = 0; j < a.GetLength(1); j++)

    {

        Console.Write($"a[{i},{j}]: ");

        a[i, j] = int.Parse(Console.ReadLine());

    }

}

Console.WriteLine();

for (int i = 0; i < a.GetLength(0); i++)

{

    for (int j = 0; j < a.GetLength(1); j++)

    {

        Console.Write($"\t{a[i, j]}");

    }

    Console.WriteLine();

}

Console.WriteLine($"\nСтолбец с минимальной суммой элементов: {Class1.Name(a) + 1}");