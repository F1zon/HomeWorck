/*
        Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

        456 -> 5
        782 -> 8
        918 -> 1
*/


int number = input(); // Записываем введённое число в переменную "number" черех функцию "input"

Console.WriteLine(GetTwo(number)); // Выводим 2 число из трёхзначеного числа "number" через функцию "GetTwo"




int input() { // Функция ввода числа
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int GetTwo(int number) { // Функция нахождения 2 числа
    int two = (number % 100) / 10;
    return two;
}
