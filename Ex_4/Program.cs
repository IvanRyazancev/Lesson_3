//Показать кубы чисел, заканчивающихся на четную цифру

Console.Write("Введите конечное число N: ");
double number = Convert.ToDouble(Console.ReadLine()!);

double numberA = number % 10;
        
if (numberA % 2 == 0)
{
    for (int i = 2; i <= number; i += 2)
    {
        double numberB =  Math.Pow(i, 3);
        Console.WriteLine("Число последовательности от 1 до " + number + " : " + i);                    
        Console.WriteLine("Число " + i + " в кубе: " + numberB);
    }
}
else
{
    for (int i = 0; i <= number; i += 2)
    {
        double numberB =  Math.Pow(i, 3);
        Console.WriteLine("Число последовательности от 1 до " + number + " : " + i);                    
        Console.WriteLine("Число " + i + " в кубе: " + numberB);
    }    
}