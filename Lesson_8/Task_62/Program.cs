/*
        Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
        Например, на выходе получается вот такой массив:
        01 02 03 04
        12 13 14 05
        11 16 15 06
        10 09 08 07
*/



int m = 4;
int n = 4;

int[,] arr = new int[m, n];

arr = GeneradeArray(arr, m, n);
Output(arr, m, n);







int[,] GeneradeArray(int[,] arr, int m, int n) {
    int i = 0, j = 0, num = 1;

    // 1) i:0  j:0-3
    for (; j < 4; j++) {
        arr[i, j] = num;
        num++;
    }

    // 2) i:0-3 j:3
    j = 3;
    for (i = 1; i < 4; i++) {
        arr[i, j] = num;
        num++;
    }

    // 3) i:3 j:3-1
    i = 3;
    for (j = 2; j > -1; j--) {
        arr[i, j] = num;
        num++;
    }

    // 4) i:3-1 j:0
    j = 0;
    for(i = 2; i > 0; i--) {
        arr[i, j] = num;
        num++;
    }

    // 5) i:1 j:0-2
    i = 1;
    for(j = 1; j < 3; j++) {
        arr[i, j] = num;
        num++;
    }

    // 6) i:2 j:2-1
    i = 2;
    for(j = 2; j > 0; j--) {
        arr[i, j] = num;
        num++;
    }

    return arr;
}

void Output(int[,] arr, int m, int n) {

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < n; j++) {
            Console.Write($"{arr[i, j]}\t");
        }
        Console.WriteLine();
    }
}