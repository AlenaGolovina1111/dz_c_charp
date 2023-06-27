
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите 1-ое число: ");
int a;
a = int.Parse(Console.ReadLine());

Console.Write("Введите 2-ое число: ");
int b;
b = int.Parse(Console.ReadLine());

Console.Write("Введите 3-ое число: ");
int c;
c = int.Parse(Console.ReadLine());

int max = a;

if (b > max)
{
max = b;
}
 
if (c > max)
{
max = c;
}

Console.WriteLine($"Наибольшее число: {max}");
