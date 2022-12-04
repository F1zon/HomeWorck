/*
        Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

        Например, задан массив:
        1 4 7 2
        5 9 2 3
        8 4 2 4
        Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Random rand = new Random();

int m = rand.Next(3, 5);
int n = rand.Next(3, 5);
double[,] array = new double[m, n];

array = GeneradeArray(array, m, n);
Output(array, m, n);

Avarage(array, m, n);




// Функции ##################################



double[,] GeneradeArray(double[,] arr, int m, int n) {
    Random rnd = new Random();

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            arr[i, j] = rnd.Next(-10, 10);
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


void Avarage(double[,] arr, int m, int n) {
        double[] avar = new double[m];
        double sum = 0;

        for (int i = 0; i < m; i++) {
                for (int j = 0; j < n; j++) {
                        sum += arr[i, j];
                }

                avar[i] = Math.Round((sum / n), 1);

                sum = 0;
        }

        for (int i = 0; i < m - 1; i++) Console.Write($"{avar[i]}; ");
        Console.Write($"{avar[m - 1]}.");

}
