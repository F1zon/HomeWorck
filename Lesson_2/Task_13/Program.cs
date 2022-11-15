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
    int three = 0;
    
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
                if (coll == 3) {
                    three = number % 10;
                } else {
                    if (coll == 4) three = (number / 10) % 10;
                    if (coll == 5) three = (number / 100) % 10;
                    if (coll == 6) three = (number / 1000) % 10;
                    if (coll == 7) three = (number / 10000) % 10;
                    if (coll == 8) three = (number / 100000) % 10;
                    if (coll == 9) three = (number / 1000000) % 10;
                    if (coll == 10) three = ((number / 10) / 1000000) % 10;
                }

                end++;
                Console.WriteLine($"three number = {three}");
            }
        }
    } else {
        Console.WriteLine("третьей цифры нет");
    }
}
