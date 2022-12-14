/*
        Задача 38: Задайте массив вещественных чисел. 
        Найдите разницу между максимальным и минимальным элементами массива.

        [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2
*/



Random rnd = new Random();
int n = rnd.Next(3, 10);

double[] arr = new double[n];
arr = CreateArray(arr, n);
OutputArray(arr, n);

Console.WriteLine($"Разница = {RazMinMax(arr, n)}"); // выводим разницу между максимальным и минимальым числом



    // Функции
double[] CreateArray(double[] arr, int n) {        // Функция создания массива
    for (int i = 0; i < n; i++) {
        arr[i] = rnd.Next(-100, 100);
        arr[i] += Math.Round(rnd.NextDouble(), 1);
    }

    return arr;
}

void OutputArray(double[] arr, int n) {         // Функция вывода массива
    Console.Write($"[{arr[0]}, ");

    for (int i = 1; i < n - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }
    Console.WriteLine($"{arr[n-1]}]");
}


double RazMinMax(double[] arr, int n) { // Функция поиска максимального числа и их разницы
    double min = arr[0];
    double max = arr[0];

    for (int i = 1; i < n; i++) {
        if (arr[i] < min) min = arr[i];
        if (arr[i] > max) max = arr[i];
    }

    Console.WriteLine($"Максимальное число в массиве: {max}");
    Console.WriteLine($"Минимальное число в массиве: {min}");


    double result = 0;
    if (min < 0) {
        min *= -1;
        result = Math.Round(min * 2 - max, 1);
    } else {
        result = Math.Round(max - min, 1);
    }

    return result;
}