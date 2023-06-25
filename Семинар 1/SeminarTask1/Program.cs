// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Напишите программу, которая на вход принимает число больше 10  
// и выдает его квадрат

////исходное число
Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine()); 

if (a <=10){
    Сonsole.WriteLine("Ваше число не соответствует условию: число больше10");
}
else
{
    
// результат квадрата исходного числа
int result = a * a;

// вывод результата 
Console.WriteLine($"Квадрат вашего числа: = {result}");
}
