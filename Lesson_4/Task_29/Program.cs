/*
        Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

        1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]
*/

int[] array = new int[8];
int n = 8;

Console.WriteLine($"Введите {n} чисел");

// Функции ввода/вывода массива
Input(array, n);
Output(array, n);




// Функция ввода массива
int[] Input(int[] arr, int n) {
    for (int i = 0; i < n; i++) {
        Console.Write(">> ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}

// Функция вывода массива
void Output(int[] arr, int n) {
    Console.Write($"[{arr[0]}, ");

    for (int i = 1; i < n - 1; i++) {
        Console.Write($"{arr[i]}, ");
    }

    Console.Write($"{arr[n - 1]}]");
}
