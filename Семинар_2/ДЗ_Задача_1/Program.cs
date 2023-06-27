// Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число: ");
int a = Parse(Console.ReadLine());
//.Next(100, 1000);
int Number3 = a/ 100;
if (a/100 ==Number3)
int Number2 = Number3%10;
if (Number3%10 ==Number2)
Console.WriteLine($"Второе число трехзначного числа: {Number2}");
