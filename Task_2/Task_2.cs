/*
        Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

        a = 5; b = 7 -> max = 7
        a = 2 b = 10 -> max = 10
        a = -9 b = -3 -> max = -3
*/


Using System;

class maxTwo {
    static void Main() {
        string menu = "yes";                                    // Переменнная для повторения цикла
        int a = 0;
        int b = 0;

        while (menu != "no") {                                  // Пока переменная "menu" = "yes", то цикл будет повторяться
            Console.Write("Enter the first number: a = ");
            a = Convert.ToInt32(Console.ReadLine());            // Вводим значения в переменную "a"

            Console.Write("Enter the second number: b = ");
            b = Convert.ToInt32(Console.ReadLine());            // Вводим значения в переменную "b"

            if (a > b) {                                        // Находим максимальное "Если а > b, то вывести "a", иначе вывести "b"
                Console.WriteLine($"max = {a}");
            } else {
                Console.WriteLine($"max = {b}");
            }

            Console.Write("Continue?(yes, no): ");              // Если хотите продолжить, то введите "yes", если нет, то "no"
            menu = Console.ReadLine();                          // Записываем ответ в переменную "menu"
            if (menu == "no") Console.WriteLine("bye bye!!");   // Если ответ "no", то прощаемся
        }
    }
}