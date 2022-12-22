/*
        Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
        Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
        Например, задан массив размером 2 x 2 x 2.
        Результат:
        66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
        34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

int m = 2;
int[,,] arr = new int[m, m, m];

arr = GeneradeArray(arr, m);
Output(arr, m);





int[,,] GeneradeArray(int[,,] arr, int m) {
        Random rnd = new Random();

        for (int i = 0; i < m; i++) {
                for (int j = 0; j < m; j++) {
                        for (int k = 0; k < m; k++) {
                                arr[i, j, k] = rnd.Next(9, 100);
                        }
                }
        }

        return arr;
}


void Output(int[,,] arr, int m) {
        for (int i = 0; i < m; i++) {
                for (int j = 0; j < m; j++) {
                        for (int k = 0; k < m; k++) {
                                Console.Write($"{arr[i, j, k]}({i}, {j}, {k}) ");
                        }
                }
                 Console.WriteLine();
        }
}