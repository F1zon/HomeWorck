/*
    Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

    m = 3, n = 4.

    0,5 7 -2 -0,2
    1 -3,3 8 -9,9
    8 7,8 -7,1 9
*/


Console.WriteLine("Введите высоту и ширину матрицы");

Console.Write("m = ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("n = ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m, n];

array = GeneradeArray(array, m, n);
Output(array, m, n);



double[,] GeneradeArray(double[,] arr, int m, int n) {
    Random rnd = new Random();

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            arr[i, j] = rnd.Next(-10, 10) + Math.Round(rnd.NextDouble(), 1);
        }
    }

    return arr;
}


void Output(double[,] arr, int m, int n) {
    Console.WriteLine();
    
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}
