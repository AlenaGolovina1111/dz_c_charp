//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.

Console.WriteLine("Введите 1-ое число: ");
int a=int.Parse(Console.ReadLine());
Console.WriteLine("Введите 2-ое число: ");
int b=int.Parse(Console.ReadLine());
if (a*a==b || b*b==a)
{
Console.WriteLine("да");
}
else 
{
Console.WriteLine("Нет");    
}
