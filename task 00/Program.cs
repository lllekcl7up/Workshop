//Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine()); // Конвертировали введенную строку в число
int square = number * number;
Console.WriteLine($"Квадрат числа {number} = {square}");



