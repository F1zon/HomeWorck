/*
        Задача 36: Задайте одномерный массив, заполненный случайными числами. 
        Найдите сумму элементов, стоящих на нечётных позициях.

        [3, 7, 23, 12] -> 19

        [-4, -6, 89, 6] -> 0
*/


    // Задаём переменные
Random rnd = new Random();                   // Оператор рандома
int n = rnd.Next(1, 10);                     // Задаём рандомный размер массива
int[] arr = new int[n];

    // Заполнение и вывод массива
arr =  CreateArray(arr, n);                  // Заполняем массив рандомными 3-х значными числами
OutputArray(arr, n);                         // Выводим массив

    // Вывод суммы
Console.WriteLine(SearchSum(arr, n));


    // Функции
int[] CreateArray(int[] arr, int n) {        // Функция создания массива
    for (int i = 0; i < n; i++) {
        arr[i] = rnd.Next(-100, 100);
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

int SearchSum(int[] arr, int n) {           // Функция нахождения суммы чисел с нечётными индексами
    int sum = 0;

    for (int i = 0; i < n; i++) 
        if (i % 2 != 0) sum += arr[i];
    
    return sum;
}