/*
        Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

        645 -> 5

        78 -> третьей цифры нет

        32679 -> 6
*/

int number = input();

if (number < 0) number = number * -1;

getThree(number);




int input() {
    int inp = Convert.ToInt32(Console.ReadLine());
    return inp;
}

void getThree(int number) {
    int end = 0;
    int del = 10;
    int coll = 1;
    
    if (number > 99)  {
        while (end != 1) {
            if (number / del != 0) {
                if (coll == 10) {
                    number = number % 10;
                } else {
                    del = del * 10;
                }
                coll++;
            } else {
                end++;
            }
        }

        int[] array = new int[coll];
        del = 10;

        for (int i = 0; i < coll; i++) {
            array[i] = number % 10;
            if (number / 10 != 0) del = del * 10;
            number = number / 10;
        }

        Console.WriteLine($"Третье число = {array[coll - 3]}");

    } else {
        Console.WriteLine("третьей цифры нет");
    }
}
