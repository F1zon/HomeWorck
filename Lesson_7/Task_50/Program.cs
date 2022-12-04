/*
        Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

        Например, задан массив:

        1 4 7 2
        5 9 2 3
        8 4 2 4

        1, 7 -> такого элемента в массиве нет
*/


Random rand = new Random();

int m = rand.Next(3, 5);
int n = rand.Next(3, 5);
int[,] array = new int[m, n];

array = GeneradeArray(array, m, n);
Output(array, m, n);

Console.WriteLine();
Console.WriteLine("Введите координаты по x и y цифры");

Console.Write("x >> ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("y >> ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SerchNum(array, x, y, m, n));



int[,] GeneradeArray(int[,] arr, int m, int n) {
    Random rnd = new Random();

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            arr[i, j] = rnd.Next(-10, 10);
        }
    }

    return arr;
}


void Output(int[,] arr, int m, int n) {
    Console.WriteLine();
    
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int SerchNum(int[,] arr, int x, int y, int m, int n) {
    if (((x < 0) || (x >= n)) || ((y < 0) || (y >= m))) {
        Console.WriteLine("такого элемента в массиве нет");

        Environment.Exit(1);
    }

    return arr[y, x];
}
