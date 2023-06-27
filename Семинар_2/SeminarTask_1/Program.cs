// Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

int randomNumber = new Random().Next(100, 1000);

Console.WriteLine ($"{randomNumber}");

int firstNumber =randomNumber/ 100;

int thirdNumber =randomNumber%10;

int Result = firstNumber*10+thirdNumber;

Console.WriteLine($"{Result}");

