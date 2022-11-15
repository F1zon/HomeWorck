/*
        Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

        645 -> 5

        78 -> третьей цифры нет

        32679 -> 6
*/

int number = input();

if (number < 0) number = number * -1;

getThree(number);




int input(int number) {
    int inp = Convert.ToInt32(Console.ReadLine());
    return inp;
}

int getThree(int number) {
    int get = 0;

    if (number > 99)  {
        int end = 0;

        while (end != 1) {

        }
    } else {
        Console.WriteLine("третьей цифры нет");
    }
}
