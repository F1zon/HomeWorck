/*
    Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    Например, задан массив:

    1 4 7 2
    5 9 2 3
    8 4 2 4
    5 2 6 7

    Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/



int m = 4;
int n = 4;

int[,] arr = new int[m, n];

arr = GeneradeArray(arr, m, n);
Output(arr, m, n);

int result = Search(arr, m, n);


Console.WriteLine($"Наименьшая сумма элементов: {result} строка");












int[,] GeneradeArray(int[,] arr, int m, int n) {
    Random rand = new Random();

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            arr[i, j] = rand.Next(1, 10);
        }
    }


    return arr;
}

void Output(int[,] arr, int m, int n) {

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


int Search(int[,] arr, int m, int n) {
    int sum = 0;
    int[] sumArray = new int[m];


    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
           sum += arr[i, j];
        }
        sumArray[i] = sum;
        sum = 0;
    }

    int res = sumArray[0];
    int iRes = 0;
    for (int i = 1; i < m; i++) {
        if (sumArray[i] < res) {
            res = sumArray[i];
            iRes = i + 1;
        }
    }


    return iRes;
}