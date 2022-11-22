/*
        Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

        452 -> 11

        82 -> 10

        9012 -> 12
*/

// Ввод данных
Console.Write($"Введите число:\n>> ");
int number = Convert.ToInt32(Console.ReadLine());

// Вызов функции суммы чисел и выврод суммы
int sum = SumNumbers(number);
Console.WriteLine(sum);


int SumNumbers(int num) {
    int copyNum = num; // Копия числа "num" для работы цикла нахождения суммы
    int sum = 0;
    int n = 1;


    while (copyNum / 10 != 0) { // Находим размер числа
        copyNum = copyNum / 10;
        n++;
    }
    copyNum = num;

    for (int i = 0; i < n; i++) { // Складываем все числа
        sum += num % 10;
        num /= 10;
    }

    return sum;
}
