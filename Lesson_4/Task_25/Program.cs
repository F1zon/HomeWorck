/*
        Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

        3, 5 -> 243 (3⁵)

        2, 4 -> 16
*/


// Ввод данных
Console.Write($"Введите чило, которое хотите возвести в степень:\n>> ");
double number = Convert.ToDouble(Console.ReadLine());

Console.Write($"Введите степень, в которую хотите возвести число:\n>> ");
double degree = Convert.ToInt32(Console.ReadLine());


// Вызов функции возведения в степень"RiseDegree" и вывод результата
double result = RiseDegree(number, degree);
Console.WriteLine($"-> {result}");



// Функция возведения в степень
double RiseDegree(double number, double degree) {
    if (degree == 0) return 1; // Если стпень = 0, то отправить 1

    double copyNum = number;
    
    if (degree > 0) { // если степень не отрицательная, то возводим число в степень
        for (int i = 1; i < degree; i++) {
            number *= copyNum;
        }
    } else { // Иначе возводим в отрицательную степень
        degree *= -1; // Преобразуем степень в положительную
        for (int i = 1; i < degree; i++) {
            number *= copyNum;
        }

        number = 1 / number; // число в отрицательной стпени a^-n = 1 / a^n
    }

    return number; // возвращаем возведённое число
}
