/*
        Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
        Напишите программу, которая покажет количество чётных чисел в массиве.

        [345, 897, 568, 234] -> 2
*/


    // Задаём переменные
Random rnd = new Random();                   // Оператор рандома
int n = rnd.Next(1, 10);                     // Задаём рандомный размер массива
int[] arr = new int[n];

    // Заполнение и вывод массива
arr =  CreateArray(arr, n);                  // Заполняем массив рандомными 3-х значными числами
OutputArray(arr, n);                         // Выводим массив

    // Поиск и вывод колличесива чётных чисел
Console.WriteLine(SearchColl(arr, n));


    // Функции
int[] CreateArray(int[] arr, int n) {        // Функция создания массива
    for (int i = 0; i < n; i++) {
        arr[i] = rnd.Next(100, 999);
    }

    return arr;
}

void OutputArray(int[] arr, int n) {         // Функция вывода массива
    Console.Write($"[{arr[0]}, ");

    for (int i = 1; i < n - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[n-1]}]");
}

int SearchColl(int[] arr, int n) { // Функция поиска чётных чисел
    int coll = 0;

    for (int i = 0; i < n; i++) {
        if (arr[i] % 2 == 0) coll++;
    }

    return coll;
}