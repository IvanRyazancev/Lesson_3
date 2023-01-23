// Задача №1. Найти кубы чисел от 1 до N

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введенное число в кубе: " + Math.Pow(number, 3));