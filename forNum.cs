/*
        Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

        5 -> 2, 4
        8 -> 2, 4, 6, 8
*/


using System;


class forNum {
    static void Main() {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());   // Получаем число

        for (int i = 1; i <= number; i++) {                 // Цикл "for" (начало = 1; пока переменная начала < "number"; прибавтьк к началу 1)
            if (i % 2 == 0) Console.Write($"{i} ");         // Проверяем число на деление на 2 без остатка и выводим
        }
    }
}