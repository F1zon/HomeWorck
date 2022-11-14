/*
        Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

        4 -> да
        -3 -> нет
        7 -> нет
*/


using System;

class tshet {
    static void Main() {
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());   // Получаем число

        if (number % 2 == 0) {                              // Проверяем число, если оно делится на 2 без остатка(чётное), то выводим "да", иначе "нет"
            Console.WriteLine("да");
        } else {
            Console.WriteLine("нет");
        }
    }
}