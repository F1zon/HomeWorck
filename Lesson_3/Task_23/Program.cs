/*
        Задача 23

        Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

        5 ->
        1 | 1
        2 | 8
        3 | 27
        4 | 64
        5 | 125
*/



// Ввод данных
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N < 1) {
    Console.WriteLine("Нужно ввести число больше 0!!!!");
    Environment.Exit(0);
}


 Console.WriteLine($"{N} -> ");
for (int i = 1; i <= N; i++) {
    Console.WriteLine($"{i} | {i * i * i}");
}