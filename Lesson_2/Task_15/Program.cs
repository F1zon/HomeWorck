/*
        Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

        6 -> да
        7 -> да
        1 -> нет
*/

int number = input();
DoDay(number);


int input() {
    int inp = Convert.ToInt32(Console.ReadLine());
    return inp;
}

void DoDay(int number) {
    if (number > 5 && number < 8) {
        Console.WriteLine("да");
    } else Console.WriteLine("нет");
}
