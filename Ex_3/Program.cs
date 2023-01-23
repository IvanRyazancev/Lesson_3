//Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число N : ");
int N = int.Parse(Console.ReadLine()!);

int multiplic = 1;

for (int count = 1; count <= N; count++)
{
    multiplic = multiplic * count;    
}

Console.WriteLine("Произведение чисел от 1 до " + N + " = " + multiplic);