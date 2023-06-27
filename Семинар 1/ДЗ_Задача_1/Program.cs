// напишите программу, которая на входе принимает 2 числа и выдает какое больше, какое меньше
Console.WriteLine("Введите 1-ое число: ");
int a;
a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int b;
b = int.Parse(Console.ReadLine());
if (a<b)
{
Console.WriteLine($"{a} - Min; {b} - Max");
}
else if (a>b)
{
Console.WriteLine($"{b} - Min; {a} - Max");
}
else 
Console.WriteLine("Числа равны");
