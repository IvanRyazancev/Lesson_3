//Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите число: ");
double number = Convert.ToDouble(Console.ReadLine()!);

double numberA = number % 10;

if (numberA % 2 == 0)
{
    double numberB =  Math.Pow(number, 3);
    Console.WriteLine("Введенное число в кубе: " + numberB);
}
else
{
    Console.WriteLine("Введенное число не заканчивается на четную цифру!");
}