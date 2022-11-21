/*
        Задача 19

        Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
        Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

        14212 -> нет

        12821 -> да

        23432 -> да
*/




// Ввод данных
Console.WriteLine("Введите число:>> ");
int number = Convert.ToInt32(Console.ReadLine());

// Проверка числа
if (number < 1) {
    Console.WriteLine("Отрицательные числа не могут быть полиндромными!");
    Environment.Exit(0);
}

// Проверка и вывод ответа на проверку полиндрома
String result = СheckPolinom(number) ? "да" : "Нет";
Console.WriteLine(result);








// Функции
// Проверка на полином
bool СheckPolinom(int num) {
    int copyNum = num; // Копия числа "num" для создания перевёртыша
    int shifter = 0;
    int n = 1;


    while (copyNum / 10 != 0) { // Находим размер числа
        copyNum = copyNum / 10;
        n++;
    }
    copyNum = num;

    for (int i = 0; i < n; i++) { // Создаём перевёрнутую переменную
        shifter = shifter * 10 + copyNum % 10;
        copyNum = copyNum / 10; 
    }

    bool result = shifter == num;
    return result;
}
