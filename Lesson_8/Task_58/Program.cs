/*
    Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
    Например, даны 2 матрицы:
    2 4 | 3 4
    3 2 | 3 3
    Результирующая матрица будет:
    18 20
    15 18
*/


int m = 2;

int[,] arr1 = new int[m, m];
int[,] arr2 = new int[m, m];

Random rnd = new Random();

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < m; j++) {
            arr1[i, j] = rnd.Next(1, 10);
            arr2[i, j] = rnd.Next(1, 10);
        }
    }



int[,] res = new int[m, m];
res = Proiz(arr1, arr2, m);


Output(arr1, m);
Console.WriteLine();
Output(arr2, m);
Console.WriteLine();
Output(res, m);













void Output(int[,] arr, int m) {
    for (int i = 0; i < m; i++) {
        for (int j = 0; j < m; j++) {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] Proiz(int[,] arr1, int[,] arr2, int m) {
    int[,] res= new int[m, m];

    for (int i = 0; i < m; i++) {
        for (int j = 0; j < m; j++) {
            res[i, j] = 0;

            for (int k = 0; k < m; k++) {
                res[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }


    return res;
}
