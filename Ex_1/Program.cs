// Задача №1. Найти кубы чисел от 1 до N

Console.Write("Введите конечное число N: ");
double number = Convert.ToDouble(Console.ReadLine()!);

Console.WriteLine("Кубы введенных чисел от 1 до " + number + ": ");

for (double i = 1; i <= number; i++)
{
    double numberA = Math.Pow(i, 3);    
    Console.WriteLine("Очередное число " + i + " в кубе: " + numberA);
}