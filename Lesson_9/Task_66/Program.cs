/*
        Задача 66:
        1) Задайте значения M и N.
        2) Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
        3) Выполнить с помощью рекурсии.

        M = 1; N = 15 -> 120
        M = 4; N = 8. -> 30
*/

Console.WriteLine("Задайте значения M и N");
Console.Write("M: "); int m = Convert.ToInt32(Console.ReadLine());
Console.Write("N: "); int n = Convert.ToInt32(Console.ReadLine());

if (m > n) {
    Console.WriteLine("Значение M должно быть меньше N!");
    Environment.Exit(1);
}

int sum = 0;
Factotial(m, n, sum);

void Factotial(int m, int n, int sum) {
    sum += m;
    if (m != n) {
        m++;
        Factotial(m, n, sum);
    } else {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N = {sum}");
    }
}